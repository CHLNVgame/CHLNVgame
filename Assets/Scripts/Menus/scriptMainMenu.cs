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
		Application.LoadLevel ("sceneProfile");
	}

	public void gotoSetting()
	{
		Application.LoadLevel ("sceneSetting");
	}

	public void gotoDailyBonus()
	{
		Application.LoadLevel ("sceneDailyBonus");
	}

	public void gotoAchivement()
	{
		Application.LoadLevel ("sceneAchievement");
	}

	public void gotoContainer()
	{
		
		Application.LoadLevel ("sceneContainer");
	}

	public void gotoDailyQuest()
	{
		Application.LoadLevel ("sceneDailyQuest");
	}

	public void gotoGamePlay()
	{
		Application.LoadLevel ("sceneGamePlay");
	}
}
