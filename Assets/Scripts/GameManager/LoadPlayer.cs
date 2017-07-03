using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour {

	[SerializeField]
	private Object[] ListPlayer = null;
	public Transform playerTrans;
	public GameObject trans;
	public int idPlayerActive;
	// Use this for initialization

	void Awake()
	{
	//	idPlayerActive = MainCharacter.Instance.getPlaneID ();

		trans = (GameObject)Instantiate (ListPlayer[idPlayerActive], transform.position, Quaternion.identity);
		trans.transform.SetParent (playerTrans);
	}

}
