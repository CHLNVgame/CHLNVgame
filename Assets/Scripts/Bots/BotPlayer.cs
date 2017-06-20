using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPlayer : MonoBehaviour {

	public void SeekPosition(Transform transfor)
	{
		transform.position = transfor.position;
	}


}
