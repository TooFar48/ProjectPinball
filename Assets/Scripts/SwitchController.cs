using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider ball;
    public Material offMaterial;
    public Material onMaterial;
    public ScoreManager scoreManager;
    public VFXManager VFXManager;
    public AudioManager audioManager;

    public float score;

    new Renderer renderer;
    SwitchState state;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            Toggle();

            audioManager.PlaySFX2(other.transform.position);
            VFXManager.PlayVFX2(other.transform.position);
        }
    }

    void Toggle()
    {
        scoreManager.AddScore(score);

        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }

    void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;

            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;

            StartCoroutine(BlinkTimerStart(5));
        }
    }

    IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
