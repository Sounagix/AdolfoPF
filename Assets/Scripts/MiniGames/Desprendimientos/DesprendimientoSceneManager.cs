using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DesprendimientoSceneManager : MiniGameManager
{
    [SerializeField]
    private DespCanvas despCanvas;


    private void OnEnable()
    {
        PlayerActions.OnPlayerDie += OnPlayerDie;
    }

    private void OnDisable()
    {
        PlayerActions.OnPlayerDie -= OnPlayerDie;
    }

    public void Awake()
    {
        InputManager.instance.InstanciatePlayers(SCENE_TYPE.GAME_PLAY);
    }

    private void Start()
    {
        InitMiniGame();
    }

    protected override void InstancePlayer(GameObject _prefab, BaseInput _baseInput)
    {
        GameObject currentPlayer = Instantiate(_prefab);
        int indexPos = Random.Range(0, initPositions.Count);
        currentPlayer.transform.position = initPositions[indexPos].position;
        initPositions.RemoveAt(indexPos);
        GamePlayPlayer player = currentPlayer.GetComponent<GamePlayPlayer>();
        player.SetUp(_baseInput);
        //player.IniPlayer(avatar);
        players.Add(player);
    }

    private void OnPlayerDie(GamePlayPlayer _gamePlayPlayer)
    {
        _gamePlayPlayer.GetComponent<Rigidbody>().AddForce(Vector3.up + (-Vector3.forward) * 4, ForceMode.Impulse);
        players.Remove(_gamePlayPlayer);
        if (players.Count <= 1)
        {
            despCanvas.SetWinner("Mono A");
        }
    }
}
