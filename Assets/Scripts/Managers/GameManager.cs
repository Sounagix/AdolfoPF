using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public enum SCENE : int
{
    MAIN, OPTIONS, SELECTOR, TAB, TUTORIAL, MINIGAME, VICTORY_SCENE,
    
    CRAZY_APPLES, VOLEY_COCO, DESPRENDIMIENTOS,
    
    NULL
};

[Serializable]
public struct playerData
{
    int monedas;
    int index;
}


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private List<playerData> playerDataList;

    private SCENE cURRENT_sCENE;

    private SCENE pREV_sCENE;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void CloseApp()
    {
        Application.Quit();
    }

    public void LoadScene(SCENE _sCENE)
    {
        SceneManager.LoadScene((int)_sCENE);
    }

    public void BackScene(SCENE _sCENE)
    {
        //pREV_sCENE = _pREV;
        cURRENT_sCENE = _sCENE;
        SceneManager.LoadScene((int)_sCENE);
    }

    public void SavePlayerInfo(List<playerData> _players)
    {
        playerDataList = _players;
    }

    public List<playerData> LoadPlayerInfo()
    {
        return playerDataList;
    }
}
