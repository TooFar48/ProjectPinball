using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;
    public ScoreManager ScoreManager;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.score.ToString();
    }
}
