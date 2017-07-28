using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour {
    public static GamePlayController instance;

	public Image healthBar;
    [SerializeField]
    private GameObject PausePanel, VictoryPanel, GameOver, GetReady;
    private bool Victory = false;
	private bool EndGame = false;
	private int health;
	private int totalHealth;
	float timerControll;
	GameObject boss;
	GameObject player;

	public void seekHP(int hp, bool firstHP)
	{
		health = hp;

		if (firstHP)
			totalHealth = hp;

		if (healthBar != null)
			healthBar.fillAmount = (float)health / totalHealth;
	}

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = Time.deltaTime * 1000.0f;
        float fps = 1.0f / Time.deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }

    void Awake()
    {

        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
		//DontDestroyOnLoad ();
    }
	void Start () {	
		boss = GameObject.FindGameObjectWithTag ("Boss");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	void Update()
	{
       
		if (Time.timeSinceLevelLoad <= Define.GAMEPLAY_TIMER_START) {
			if(player == null)
				player = GameObject.FindGameObjectWithTag ("Player");
			if(boss == null)
				boss = GameObject.FindGameObjectWithTag ("Boss");
		}
       
		if (Time.timeSinceLevelLoad >= Define.GAMEPLAY_TIMER_READY && Time.timeSinceLevelLoad <= Define.GAMEPLAY_TIMER_READY + Define.GAMEPLAY_TIMER_READY) {
			ShowGetReady ();
		} else {
			HideGetReady ();
		}

		if (EndGame) {
			if (Victory) {
				if (Time.time > timerControll) {
					ShowVictoryPanel ();
				}
				if (Time.time > timerControll + Define.GAMEPLAY_TIMER_DELAY)
					Application.LoadLevel (Define.sceneMainMenu);
			} else {
				if (Time.time > timerControll) {
					ShowGameOver ();
					EndGame = false;
				}
			}
		} else {
			CheckGameVictory ();
			CheckGameOver ();
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
        //Application.Quit();
		PausePanel.SetActive(false);
		Time.timeScale = 1f;
		SceneManager.LoadScene (Define.sceneMainMenu);
    }
    public void ShowVictoryPanel()
    {
        VictoryPanel.SetActive(true);
    }

	public void SetGameVictory(bool bVictory)
	{
		if (bVictory)
			timerControll = Time.time + Define.GAMEPLAY_TIMER_DELAY;
		Victory = bVictory;
	}
    public bool GetGameVictory()
    {
		return VictoryPanel.activeSelf;
    }
	public void SetGameEndGame(bool bEndGame)
	{
		timerControll = Time.time + Define.GAMEPLAY_TIMER_DELAY;
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
        Time.timeScale = 1f;
        GameOver.SetActive (false);
		
		SceneManager.LoadScene (Define.sceneMainMenu);
	}
	public void ShowGetReady()
	{
		if(!GetReady.activeSelf)
			GetReady.SetActive (true);
	}
	public void HideGetReady()
	{
		if(GetReady.activeSelf)
			GetReady.SetActive (false);
	}
	void CheckGameVictory()
	{
		if (boss == null && !Victory) {
			SetGameEndGame (true);
			SetGameVictory (true);
		}
	}
	void CheckGameOver()
	{
		if (player == null && !EndGame) {			
			SetGameEndGame (true);
		}
	}
	public float GetTimerControll()
	{
		return timerControll;
	}
}
