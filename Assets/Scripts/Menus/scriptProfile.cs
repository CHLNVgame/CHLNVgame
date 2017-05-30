using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptProfile : MonoBehaviour {

	public GameObject pnSelectAvatar;
	// Use this for initialization
	void Start () {
		pnSelectAvatar.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void SelectAvatar()
	{
		pnSelectAvatar.SetActive (true);
	}

	public void BackToProfile()
	{
		pnSelectAvatar.SetActive (false);
	}

	public void BackToMainMenu()
	{
		Application.LoadLevel ("sceneMainMenu");
	}
}
