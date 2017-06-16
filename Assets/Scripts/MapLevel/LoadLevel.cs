using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

	public int idLevel;
	public GameObject[] listLevel = null;
	// Use this for initialization
	void Start () {

		if (GameManager.instance != null)
			idLevel = GameManager.instance.level;
		else {
			Debug.Log (" GameManager is null so get default level = 0");
			idLevel = 0;
		}

		Instantiate (listLevel [idLevel], transform.position, Quaternion.identity);	
	}

}
