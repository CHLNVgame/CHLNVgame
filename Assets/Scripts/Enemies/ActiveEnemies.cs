using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActiveEnemies : MonoBehaviour {

	float deltaTime = 0.0f;
	/*
	public GameObject[] listObject;
	public int lenghtList = 0;
	*/
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
