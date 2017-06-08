using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMap : MonoBehaviour {

	public int idMap;
	public GameObject[] listMap = null;
	// Use this for initialization
	void Start () {
		Instantiate (listMap [idMap], transform.position, Quaternion.identity);	
	}
}
