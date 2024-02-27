using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoleyCocoPlayerKey : GamePlayPlayer
{
    private bool onGround;

    //private void OnEnable()
    //{
    //    InputsActions.GamePlayActionMovePC += MovePlayer;
    //    InputsActions.GamePlayActionEnterPC += JumpPlayer;
    //}
    //private void OnDisable()
    //{
    //    InputsActions.GamePlayActionMovePC -= MovePlayer;
    //    InputsActions.GamePlayActionEnterPC += JumpPlayer;
    //}

    public override void SetUp(BaseInput _baseInput)
    {
        base.SetUp(_baseInput);
        int side = (playerInput.GetIndex().Equals(0) || playerInput.GetIndex().Equals(2) ? 0 : 1);
        print("Player " + playerInput.GetIndex() + " " + side);
        LimitsActions.setPlayer(playerInput, side);
    }

    protected override void OnEnterAction2Pressed()
    {
        BallActions.ServeBallByPlayer(playerInput.GetIndex());
    }

    protected override void JumpPlayer()
    {
        if (onGround)
        {
            base.JumpPlayer();
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            onGround = true;
        }
    }
}
