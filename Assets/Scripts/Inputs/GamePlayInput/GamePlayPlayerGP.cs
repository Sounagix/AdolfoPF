using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayPlayerGP : GamePlayPlayer
{
    private void OnEnable()
    {
        InputsActions.GamePlayActionMoveGP += MovePlayer;
        InputsActions.GamePlayActionEnterGP += JumpPlayer;
    }
    private void OnDisable()
    {
        InputsActions.GamePlayActionMoveGP -= MovePlayer;
        InputsActions.GamePlayActionEnterGP -= JumpPlayer;
    }
}
