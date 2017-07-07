using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
        Debug.Log(" 111111111111111111 ");
	}
	
	// Update is called once per frame
	void Update () {
      //  Debug.Log(" 222222222222222222 ");
        transform.position += Vector3.up * speed * Time.deltaTime;
	}
}
