using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActiveEnemies : MonoBehaviour {

	float deltaTime = 0.0f;
	/*
	public GameObject[] listObject;
	public int lenghtList = 0;
	*/
	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (0.0f, 0.0f, 0.5f, 1.0f);
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);
	}

	void Awake()
	{
	}
	// Update is called once per frame
	void Update () {
		/*
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

		if(Time.timeSinceLevelLoad > lenghtList * 10f && lenghtList  < listObject.Length)
		{
			listObject [lenghtList].SetActive (true);
			lenghtList++;
		}*/
		if (transform.childCount == 0)
			Destroy (gameObject);
	}
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Actived") {
			
			transform.GetChild(0).gameObject.SetActive(true);
		}
	}
}
