using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoleyCocoPlayerKey : GamePlayPlayer
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
