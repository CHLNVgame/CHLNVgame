using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPlayer : MonoBehaviour {

	private bool isLeftBot = false;
	// Use this for initialization
	void Awake () {
		if (transform.position == Define.LEFT_BOT_POS) {
			isLeftBot = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (isLeftBot) {
			transform.position = Player.Instance.leftBot.position;
		} else {
			transform.position = Player.Instance.rightBot.position;
		}
	}
}
