using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {

	public int idLevel;
	public GameObject[] listLevel = null;
	// Use this for initialization
	void Start () {
		Instantiate (listLevel [idLevel], transform.position, Quaternion.identity);	
	}

}
