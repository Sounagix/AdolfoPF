using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;


public enum SCENE_TYPE : int
{
    GAME_PLAY, MENU
}

public class InputManager : MonoBehaviour
{
    // Número máximo de jugadores
    [SerializeField]
    private int maxPlayers;

    // Prefabs de los jugadores
    [SerializeField]
    private GameObject menuKeyboard, menuGamePad, gamePlayGamePad, gamePlayKeyboard;

    // Lista de jugadores creados
    private List<BaseInput> players = new List<BaseInput>();
    
    public static InputManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SetUp();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void SetUp()
    {
        var devices = InputSystem.devices;

        foreach (var device in devices)
        {
            // Verificar si el dispositivo es un gamepad
            if (device is Gamepad)
            {
                //GameObject gamePadPlayer = Instantiate(gamePadPlayerPrefab);
                //gamePadPlayer.GetComponent<GamePadMenuInput>().InitGamePad(InputSystem.GetDevice<Gamepad>());
                //players.Add(gamePadPlayer.GetComponent<GamePadMenuInput>());
                if (device.displayName.Contains("DualShock") || device.displayName.Contains("DualSense"))
                {
                    Debug.Log("Se ha detectado un gamepad de PlayStation.");
                }
                else if (device.displayName.Contains("Xbox"))
                {
                    Debug.Log("Se ha detectado un gamepad de xbox.");
                }
            }
            else if (device is Keyboard)
            {
                Debug.Log("Se encontró un teclado " + device.GetType().Name);
                //GameObject keyboardPlayer = Instantiate(keyboardPlayerPrefab);
                //keyboardPlayer.GetComponent<KeyboadInput>().InitKeyboard(InputSystem.GetDevice<Keyboard>());
                //players.Add(keyboardPlayer.GetComponent<KeyboadInput>());
            }
            else if (device is Joystick)
            {
                Debug.Log("Se encontró un joystick " + device.GetType().Name);
            }
        }

        //for (int i = 0; i < InputSystem.devices.Count; i++)
        //{
        //    switch (InputSystem.devices[i].displayName)
        //    {
        //        case "Keyboard":

        //            break;
        //        case "Xbox Controller":

        //            break;
        //        case "Joystick":
        //            players[i] = new JoystickInput();
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }

    public void InstanciatePlayers(SCENE_TYPE sCENE_TYPE)
    {
        var devices = InputSystem.devices;
        foreach (var device in devices)
        {
            if (device is Gamepad)
            {
                GameObject gamePadPlayer = Instantiate(sCENE_TYPE.Equals(SCENE_TYPE.MENU) ? menuGamePad : gamePlayGamePad);
                //gamePadPlayer.GetComponent<GamePadMenuInput>().InitGamePad(InputSystem.GetDevice<Gamepad>());
                players.Add(gamePadPlayer.GetComponent<BaseInput>());
                players[players.Count - 1].SetIndex(players.Count - 1);
            }
            else if (device is Keyboard)
            {
                GameObject keyboardPlayer = Instantiate(sCENE_TYPE.Equals(SCENE_TYPE.MENU) ? menuKeyboard : gamePlayKeyboard);
                //keyboardPlayer.GetComponent<KeyboadInput>().InitKeyboard(InputSystem.GetDevice<Keyboard>());
                players.Add(keyboardPlayer.GetComponent<BaseInput>());
                players[players.Count - 1].SetIndex(players.Count - 1);
            }
            else if (device is Joystick)
            {
            }
            
        }
    }

    public BaseInput GetPlayer(int index)
    {
        return players[index];
    }

    public int GetNumPlayers()
    {
        return players.Count;
    }

    public BaseInput[] GetPlayers()
    {
        return players.ToArray();
    }
}
