using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var worldHeight = Camera.main.orthographicSize * 2; // get Height Camera
		var worldWidth = worldHeight*Screen.width/Screen.height; //get Width Camera
		transform.localScale = new Vector2(worldWidth, worldHeight); // Full Screen
	}
}
