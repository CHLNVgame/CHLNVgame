using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScroll : MonoBehaviour {
	public float speedScroll = 0;
	
	private float scrollY = 0;
	private Material mat;

	void Start () {
		mat = GetComponent<Renderer> ().material;
	}

	// Update is called once per frame
	void Update () {
		scrollY = Mathf.Repeat (Time.time * speedScroll, 1);
		mat.SetTextureOffset ("_MainTex", new Vector2(0,scrollY));
	}
}
