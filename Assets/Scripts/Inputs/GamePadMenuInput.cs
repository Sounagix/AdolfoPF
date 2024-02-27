using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePadMenuInput : BaseInput
{
    private Gamepad gamePad;

    private void Awake()
    {
        iNPUT = INPUT.GAMEPAD;
    }

    private void OnEnable()
    {
        if (inputAction == null)
        {
            inputAction = new Inputs();
            inputAction.MenuMando.Mov.performed += Move;
            inputAction.MenuMando.Selection.performed += Enter;
            inputAction.MenuMando.Start.performed += StartButton;
            inputAction.Enable();
        }
    }


    private void OnDisable()
    {
        inputAction.MenuMando.Mov.performed -= Move;
        inputAction.MenuMando.Selection.performed -= Enter;
        inputAction.MenuMando.Start.performed -= StartButton;
        inputAction.Disable();
    }
}
