using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scriptMainMenu : MonoBehaviour {


	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void gotoProfile()
	{
		Application.LoadLevel ( Define.sceneProfile);
	}

	public void gotoSetting()
	{
		Application.LoadLevel (Define.sceneSetting);
	}

	public void gotoDailyBonus()
	{
		Application.LoadLevel (Define.sceneDailyBonus);
	}

	public void gotoAchivement()
	{
		Application.LoadLevel (Define.sceneAchievement);
	}

	public void gotoContainer()
	{
		
		Application.LoadLevel (Define.sceneContainer);
	}

	public void gotoDailyQuest()
	{
		Application.LoadLevel (Define.sceneDailyQuest);
	}

	public void gotoGamePlay(string level)
	{
		GameManager.instance.setLevel (level);
		Application.LoadLevel (Define.sceneLevel1);
	}
}
