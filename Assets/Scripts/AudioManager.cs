using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfxAudioSource2;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    
    public void PlaySFX(Vector3 spawnPos)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPos, Quaternion.identity);
    }

    public void PlaySFX2(Vector3 spawnPos)
    {
        GameObject.Instantiate(sfxAudioSource2, spawnPos, Quaternion.identity);
    }
}
