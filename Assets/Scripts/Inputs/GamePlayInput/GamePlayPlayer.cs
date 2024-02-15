using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GamePlayPlayer : MonoBehaviour
{
    [SerializeField]
    protected float movSpeed, jumpSpeed, limitSpeed;

    protected Rigidbody rB;

    protected bool canMove = true;

    protected BaseInput playerInput;

    protected Vector3 dir;


    public virtual void SetUp(BaseInput _baseInput)
    {
        rB = GetComponent<Rigidbody>();
        playerInput = _baseInput;
        playerInput.SetMoveAction(MovePlayer);
        playerInput.SetEnterAction(JumpPlayer);
        playerInput.SetStartAction(StartMovePlayer);
        playerInput.SetEndMoveAction(EndMovePlayer);
    }

    protected virtual void MovePlayer(Vector2 vector)
    {
        Vector3 dir = new Vector3(vector.x, 0.0f, vector.y);
        if (canMove && MovementAccepted(dir))
            rB.AddForce(dir * movSpeed, ForceMode.Impulse);
    }

    protected virtual void StartMovePlayer()
    {
        canMove = true;
    }

    protected virtual void EndMovePlayer()
    {
        canMove = false;
    }

    protected virtual void JumpPlayer()
    {
        if(canMove)
            rB.AddForce(jumpSpeed * Vector3.up, ForceMode.Impulse);
    }

    protected virtual bool MovementAccepted(Vector3 dir)
    {
        return rB.velocity.magnitude < limitSpeed;
    }

    public void OnDiePlayer()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        if (canMove)
        {
            rB.velocity = dir * movSpeed;
        }
    }
}
