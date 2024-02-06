using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputsActions
{
    public static Action<Vector2> menuActionMove;
    public static Action MenuActionEnter;
    public static Action StartActionEnter;
    public static Action OpenActionMenu;

    public static Action<Vector2> GamePlayActionMovePC;
    public static Action GamePlayActionEnterPC;
    public static Action GamePlayActionStartPC;
    public static Action GamePlayActionOpenMenuPC;

    public static Action<Vector2> GamePlayActionMoveGP;
    public static Action GamePlayActionEnterGP;
    public static Action GamePlayActionStartGP;
    public static Action GamePlayActionOpenMenuGP;
}


public static class PlayerActions
{
    public static Action<GamePlayPlayer> OnPlayerDie;
}
