using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespGamePlayKB : GamePlayPlayer
{
    [SerializeField]
    private Animator animator;


    private void OnEnable()
    {
        InputsActions.GamePlayActionEnterPC += JumpPlayer;
    }
    private void OnDisable()
    {
        InputsActions.GamePlayActionEnterPC += JumpPlayer;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            PlayerActions.OnPlayerDie?.Invoke(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = true;
            animator.SetBool("Jump", false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = false;
        }
    }

    protected override void JumpPlayer()
    {
        animator.SetBool("Jump", true);
        base.JumpPlayer();
    }
}
