using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{

    [SerializeField]
    protected GameObject pcPlayerPrefab;

    [SerializeField]
    protected GameObject gamePadPlayerPrefab;

    [SerializeField]
    protected List<Transform> initPositions;

    [SerializeField]
    protected GameObject caniAvatarPrefab;

    protected List<GamePlayPlayer> players = new List<GamePlayPlayer>();


    protected virtual void InitMiniGame()
    {
        foreach (BaseInput bI in InputManager.instance.GetPlayers())
        {
            CreatePlayer(bI);
        }
    }

    protected virtual void CreatePlayer(BaseInput _baseInput)
    {
        switch (_baseInput.GetTypeInput())
        {
            case INPUT.KEYBOARD:
                InstancePlayer(pcPlayerPrefab, _baseInput);
                break;
            case INPUT.GAMEPAD:
                InstancePlayer(gamePadPlayerPrefab, _baseInput);
                break;
            case INPUT.JOYSTICK:
                break;
        }
    }

    protected virtual void InstancePlayer(GameObject _prefab, BaseInput _baseInput)
    {
        GameObject currentPlayer = Instantiate(_prefab);
        currentPlayer.transform.position = initPositions.First().position;
        currentPlayer.transform.rotation = initPositions.First().rotation;
        initPositions.Remove(initPositions.First());
        currentPlayer.GetComponent<GamePlayPlayer>().SetUp(_baseInput);

        //GameObject avatar = Instantiate(caniAvatarPrefab);
        //avatar.GetComponent<PlayerAttachment>().InitAvatar(currentPlayer.transform);
        //GamePlayPlayer player = currentPlayer.GetComponent<GamePlayPlayer>();
        //player.IniPlayer(avatar);
        //players.Add(player);
    }
}
