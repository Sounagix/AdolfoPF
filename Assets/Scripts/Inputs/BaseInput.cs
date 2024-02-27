using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public enum INPUT : int
{
    KEYBOARD, GAMEPAD, JOYSTICK
}

public class BaseInput : MonoBehaviour
{
    [SerializeField]
    protected InputActionAsset inputActionAsset;

    protected Inputs inputAction;

    protected bool canMove = true;

    protected INPUT iNPUT;

    protected int playerIndexPosition;

    protected UnityAction<Vector2> moveAction;

    protected UnityAction enterAction, startAction, openMenuAction, startMoveAction, endMoveAction, startButtonAction, southAction;

    private void OnEnable()
    {
        if (inputAction == null)
        {
            inputAction = new Inputs();
            inputAction.Enable();
        }
    }


    private void OnDisable()
    {
        inputAction.Disable();
    }

    public virtual void Move(InputAction.CallbackContext context)
    {
        if(canMove)
            moveAction?.Invoke(context.ReadValue<Vector2>());
        if (context.started)
        {
            startMoveAction?.Invoke();
        }
        else if(context.canceled)
        {
            endMoveAction?.Invoke();
        }

        //if (context.performed && canMove)
        //{
        //    InputsActions.menuActionMove?.Invoke(context.ReadValue<Vector2>());
        //}
    }

    public virtual void Enter(InputAction.CallbackContext context)
    {
        if(canMove)
            enterAction?.Invoke();
        //if (context.performed && canMove)
        //{
        //    InputsActions.MenuActionEnter?.Invoke();
        //}
    }

    public virtual void SouthAction(InputAction.CallbackContext context)
    {
        if(canMove)
            southAction?.Invoke();
    }

    public virtual void StartButton(InputAction.CallbackContext context)
    {
        if(canMove)
            startAction?.Invoke();
        //if (context.performed && canMove)
        //{
        //    InputsActions.StartActionEnter?.Invoke();
        //}
    }

    public virtual void OpenMenu(InputAction.CallbackContext context)
    {
        if(canMove)
            openMenuAction?.Invoke();

        //if (context.performed && canMove)
        //{
        //    InputsActions.OpenActionMenu?.Invoke();
        //}
    }

    public void SetIndex(int _index)
    {
        playerIndexPosition = _index;
    }

    public int GetIndex()
    {
        return playerIndexPosition;
    }

    public void BlockInput()
    {
        canMove = false;
    }

    public void ReleaseInput()
    {
        canMove = true;
    }

    public INPUT GetTypeInput()
    {
        return iNPUT;
    }

    public void SetMoveAction(UnityAction<Vector2> _moveAction)
    {
        moveAction = _moveAction;
    }

    public void SetEnterAction(UnityAction _enterAction)
    {
        enterAction = _enterAction;
    }

    public void SetStartAction(UnityAction _startAction)
    {
        startAction = _startAction;
    }

    public void SetOpenMenuAction(UnityAction _openMenuAction)
    {
        openMenuAction = _openMenuAction;
    }

    public void SetStartMoveAction(UnityAction _startMoveAction)
    {
        startMoveAction = _startMoveAction;
    }

    public void SetEndMoveAction(UnityAction _EndMoveAction)
    {
        endMoveAction = _EndMoveAction;
    }

    public void SetStartButtonPressed(UnityAction _startButtonAction)
    {
        startButtonAction = _startButtonAction;
    }

    public void SetEnterAction2(UnityAction _EnterAction2)
    {
        southAction = _EnterAction2;
    }
}
