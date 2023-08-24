using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider ball;
    public ScoreManager ScoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            ScoreManager.AddScore(score);
        }
    }
}
