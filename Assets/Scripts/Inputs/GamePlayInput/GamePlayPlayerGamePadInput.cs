using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePlayPlayerGamePadInput : BaseInput
{
    private Gamepad gamePad;
    public void InitGamePad(Gamepad _gamePad)
    {
        gamePad = _gamePad;
        iNPUT = INPUT.GAMEPAD;
    }

    private void OnEnable()
    {
        if (inputAction == null)
        {
            inputAction = new Inputs();
            inputAction.GamePlayGamePad.MovGp.performed += Move;
            inputAction.GamePlayGamePad.ActionGp.performed += Enter;
            inputAction.GamePlayGamePad.MenuGp.performed += OpenMenu;
            inputAction.Enable();
        }
    }


    private void OnDisable()
    {
        inputAction.GamePlayGamePad.MovGp.performed -= Move;
        inputAction.GamePlayGamePad.ActionGp.performed -= Enter;
        inputAction.GamePlayGamePad.MenuGp.performed -= OpenMenu;
        inputAction.Disable();
    }

    public override void Move(InputAction.CallbackContext context)
    {
        if (context.performed && canMove)
        {
            InputsActions.GamePlayActionMoveGP?.Invoke(context.ReadValue<Vector2>());
        }
    }

    public override void Enter(InputAction.CallbackContext context)
    {
        if (context.performed && canMove)
        {
            InputsActions.GamePlayActionEnterGP?.Invoke();
        }
    }

    public override void OpenMenu(InputAction.CallbackContext context)
    {
        if (context.performed && canMove)
        {
            InputsActions.GamePlayActionOpenMenuGP?.Invoke();
        }
    }
}
