using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }

    public void AddScore(float addition)
    {
        score += addition;
    }
}
