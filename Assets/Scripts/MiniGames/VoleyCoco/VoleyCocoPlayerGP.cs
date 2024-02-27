using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VoleyCocoPlayerGP : GamePlayPlayer
{
    private bool onGround = false;

    public override void SetUp(BaseInput _baseInput)
    {
        base.SetUp(_baseInput);
        int side = (playerInput.GetIndex().Equals(0) || playerInput.GetIndex().Equals(2) ? 0 : 1);
        print("Player " + playerInput.GetIndex() + " " + side);
        LimitsActions.setPlayer(playerInput, side);
    }


    protected override void OnEnterAction2Pressed()
    {
        print("2ACTION");
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
