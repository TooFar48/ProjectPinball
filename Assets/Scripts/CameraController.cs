using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    Vector3 defaultPos;

    public float returnTime;
    public float followSpeed;
    public float length;

    public bool hasTarget { get { return target != null; } }

    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPos = target.position + (targetToCameraDirection * length);

            transform.position = Vector3.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime); ;
        }
    }

    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();

        target = target.transform;
        length = targetLength;
    }

    public void GoBackToDefault()
    {
        StopAllCoroutines();

        target = null;

        StartCoroutine(MovePos(defaultPos, returnTime));
    }

    IEnumerator MovePos(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0f, 1f, timer / time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }
}
