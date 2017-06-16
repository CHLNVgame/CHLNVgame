using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public int level;


	void Start()
	{
		if (instance != null) {
			return;
		}

		instance = this;
		DontDestroyOnLoad (this);
	}

	public void setLevel (string text)
	{
		level = int.Parse (text);
	}
}
