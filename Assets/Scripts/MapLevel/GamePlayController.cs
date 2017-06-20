using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour {
    public static GamePlayController instance;
    [SerializeField]
    private GameObject PausePanel, VictoryPanel, GameOver;
    private bool Victory = false;
	private bool EndGame = false;
    void Awake()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
		//DontDestroyOnLoad ();
    }
	void Update()
	{
		if (EndGame) {
			EndGame = false;
			//Debug.Log ("EEEEEEEEEEEEEE");
			if (Victory) {
				ShowVictoryPanel ();
				Application.LoadLevel (Define.sceneMainMenu);
			} else {
				ShowGameOver ();
			}
		}
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
    }

	public void SetGameVictory(bool bVictory)
	{
		Victory = bVictory;
	}
    public bool GetGameVictory()
    {
        return Victory;
    }
	public void SetGameEndGame(bool bEndGame)
	{
		EndGame = bEndGame;
	}
	public bool GetEndGame()
	{
		return EndGame;
	}

	public void ShowGameOver()
	{
		GameOver.SetActive (true);
		Time.timeScale = 0f;
	}
	public void LeaveGame()
	{
		GameOver.SetActive (false);
		Time.timeScale = 1f;
		Application.LoadLevel (Define.sceneMainMenu);
	}
}
