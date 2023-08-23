using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider ball;
    public Material offMaterial;
    public Material onMaterial;

    bool isOn;
    new Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            Set(!isOn);
            Debug.Log("wow");
        }
    }

    void Set(bool active)
    {
        isOn = active;
        if (isOn == true)
        {
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = offMaterial;
        }
    }
}
