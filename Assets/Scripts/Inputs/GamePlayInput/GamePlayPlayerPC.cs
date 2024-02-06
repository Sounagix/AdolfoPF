using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GamePlayPlayerPC : GamePlayPlayer
{
    private void OnEnable()
    {
        InputsActions.GamePlayActionMovePC += MovePlayer;
        InputsActions.GamePlayActionEnterPC += JumpPlayer;
    }
    private void OnDisable()
    {
        InputsActions.GamePlayActionMovePC -= MovePlayer;
        InputsActions.GamePlayActionEnterPC += JumpPlayer;
    }
}
