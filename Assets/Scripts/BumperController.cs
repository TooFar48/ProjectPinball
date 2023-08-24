using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;
    public float multiplier;
    public float score;

    public AudioManager audioManager;
    public VFXManager VFXManager;
    public ScoreManager scoreManager;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ball)
        {
            Rigidbody ballRB = ball.GetComponent<Rigidbody>();
            ballRB.velocity *= multiplier;

            anim.SetTrigger("Hit");

            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
            scoreManager.AddScore(score);
        }
    }
}
