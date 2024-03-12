using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyApplesManager : MiniGameManager
{
    [SerializeField]
    private CrazyAppleCanvas crazyAppleCanvas;

    [SerializeField]
    private Transform center;

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
        GameObject avatar = Instantiate(caniAvatarPrefab);
        PlayerAttachment pA = avatar.GetComponent<PlayerAttachment>();
        pA.InitAvatar(currentPlayer.transform,center);
        Animator animator = pA.GetAnimator();
        GamePlayPlayer player = currentPlayer.GetComponent<GamePlayPlayer>();
        player.SetAnimator(animator);
        player.SetUp(_baseInput);
        //player.IniPlayer(avatar);
        players.Add(player);
    }

    private void OnPlayerDie(GamePlayPlayer _gamePlayPlayer)
    {
        players.Remove(_gamePlayPlayer);
        if (players.Count <= 1)
        {
            crazyAppleCanvas.SetWinner(players[0].name);
        }
    }
}
