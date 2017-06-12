using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour {
    public static GamePlayController instance;
    [SerializeField]
    private GameObject PausePanel, VictoryPanel;
    private bool Victory = false;
    void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
	public void PauseGame()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ShowVictoryPanel()
    {
        VictoryPanel.SetActive(true);
        Victory = true;
    }
    public bool GetGameVictory()
    {
        return Victory;
    }
}
