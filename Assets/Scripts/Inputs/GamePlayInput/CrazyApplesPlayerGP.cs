using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyApplesPlayerGP : GamePlayPlayer
{

    [SerializeField]
    protected GameObject ptcPrefab;

    [SerializeField]
    protected float repulsiveForce;

    private Animator animator;

    public override void SetUp(BaseInput _baseInput)
    {
        base.SetUp(_baseInput);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LostZone"))
        {
            CrazyApplesSounds.instance.PlaySound(C_A_SOUNDS.FALLING);
            // Asignar puntos etc...
            PlayerActions.OnPlayerDie(this);
        }
    }

    private void LateUpdate()
    {
        animator.SetFloat("MovSpeed",Mathf.Abs(rB.velocity.magnitude));
    }

    protected override void JumpPlayer()
    {
        base.JumpPlayer();
        animator.SetBool("Jump",true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CrazyApplesSounds.instance.PlaySound(C_A_SOUNDS.IMPACT);

            GameObject ptc = Instantiate(ptcPrefab);
            ptc.transform.position = collision.GetContact(0).point;

            Vector3 dir = collision.transform.position - transform.position;
            rB.velocity = Vector3.zero;
            rB.AddForce(-dir * repulsiveForce, ForceMode.Force);
        }
        else if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            canMove = false;
            animator.SetBool("Jump", false);
        }
    }

    public override void SetAnimator(Animator _animator)
    {
        animator = _animator;
    }
}
