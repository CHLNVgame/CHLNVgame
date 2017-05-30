using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptSetting : MonoBehaviour {

	public GameObject pnContentSetting;
	public GameObject pnContentCommon;

	int currState = 0; // 0 Setting, 1 Common
	// Use this for initialization
	void Start () {
		currState = 0;
		pnContentSetting.SetActive (true);
		pnContentCommon.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BackPreviousMenu()
	{
		Debug.Log (" +++++++++++ currState: "+currState);
		if (currState == 0) 
		{
			Application.LoadLevel ("sceneMainMenu");
		}
		else if (currState == 1) 
		{
			currState = 0;
			pnContentCommon.SetActive (false);
			pnContentSetting.SetActive (true);
		}
	}

	public void SelectCommon()
	{
		currState = 1;
		pnContentCommon.SetActive (true);
		pnContentSetting.SetActive (false);
	}


}
