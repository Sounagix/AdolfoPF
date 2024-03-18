using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DespCanvas : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private GameObject panel;

    [SerializeField]
    private string textToShow;

    [SerializeField]
    private float timeToLoadTab;

    public void SetWinner(string name)
    {
        panel.SetActive(true);
        text.text = textToShow + " " + name;
        Invoke(nameof(LoadTab), timeToLoadTab);
    }

    private void LoadTab()
    {
        GameManager.instance.LoadScene(SCENE.TAB);
    }

}
