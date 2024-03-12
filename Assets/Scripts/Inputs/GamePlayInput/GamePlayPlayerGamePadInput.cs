using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GamePlayPlayerGamePadInput : GamePlayPlayer
{
    private Gamepad gamePad;

    private bool onGround = false;


    public override void SetUp(BaseInput _baseInput)
    {
        base.SetUp(_baseInput);
    }


    protected override void JumpPlayer()
    {
        if (onGround)
        {
            base.JumpPlayer();
            onGround = false;
        }
    }
}
