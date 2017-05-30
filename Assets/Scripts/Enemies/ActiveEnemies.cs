using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActiveEnemies : MonoBehaviour {

	float deltaTime = 0.0f;

	public GameObject[] listObject;

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
	// Update is called once per frame
	void Update () {
		
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        //if(Time.timeSinceLevelLoad > 50f) {
        //    listObject [listObject.Length - 1].SetActive (true);
        //}
        //else if (Time.timeSinceLevelLoad > 40f)
        //{
        //    listObject[listObject.Length - 2].SetActive(true);
        //}
        //else if(Time.timeSinceLevelLoad > 30f) 
        //{
        //    listObject [listObject.Length - 3].SetActive (true);
        //} else if(Time.timeSinceLevelLoad > 20f) {
        //    listObject [listObject.Length - 4].SetActive (true);
        //} else if(Time.timeSinceLevelLoad > 10f) {
        //    listObject [listObject.Length - 5].SetActive (true);
        //} else if(Time.timeSinceLevelLoad > 5f) {
        //    listObject [listObject.Length - 6].SetActive (true);
        //}
	}
}
