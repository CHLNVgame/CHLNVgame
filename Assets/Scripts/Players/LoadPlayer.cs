using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

	[SerializeField]
	private Object[] ListPlayer = null;

	public int idPlayerActive;
	// Use this for initialization

	void Awake()
	{
		idPlayerActive = MainCharacter.Instance.getPlaneID ();

		Instantiate (ListPlayer[idPlayerActive], transform.position, Quaternion.identity);
	}

}
