using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespGamePlayGP : GamePlayPlayer
{
    [SerializeField]
    private Animator animator;

    private void OnEnable()
    {
        InputsActions.GamePlayActionEnterGP += JumpPlayer;
    }
    private void OnDisable()
    {
        InputsActions.GamePlayActionEnterGP += JumpPlayer;
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
            animator.SetBool("Jump", true);
        }
    }

    protected override void JumpPlayer()
    {
        animator.SetBool("Jump", true);
        base.JumpPlayer();
    }

}
