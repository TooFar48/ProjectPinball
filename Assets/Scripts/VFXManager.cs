using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    public GameObject vfxSource2;

    public void PlayVFX(Vector3 spawnPos)
    {
        GameObject.Instantiate(vfxSource, spawnPos, Quaternion.identity);
    }

    public void PlayVFX2(Vector3 spawnPos)
    {
        GameObject.Instantiate(vfxSource2, spawnPos, Quaternion.identity);
    }
}
