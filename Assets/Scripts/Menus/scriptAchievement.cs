using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class scriptAchievement : MonoBehaviour {

	public Transform btProgress;
	public Transform btRanking;
	public GameObject pnContentProgress;
	public GameObject pnContentRanking;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BackToMainMenu()
	{
		Application.LoadLevel ("sceneMainMenu");
	}

	public void showProgress ()
	{
		btProgress.GetComponent<Button> ().interactable = false;
		btRanking.GetComponent<Button> ().interactable = true;

		pnContentProgress.SetActive (true);
		pnContentRanking.SetActive (false);
	}

	public void showRanking()
	{
		btProgress.GetComponent<Button> ().interactable = true;
		btRanking.GetComponent<Button> ().interactable = false;

		pnContentProgress.SetActive (false);
		pnContentRanking.SetActive (true);
	}

}
