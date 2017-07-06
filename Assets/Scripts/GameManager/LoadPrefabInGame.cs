using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefabInGame : MonoBehaviour {

    public static LoadPrefabInGame instance;

    [Header("Prefab")]
    public GameObject[] listBonus;
    public GameObject[] listExplosion;
    public GameObject[] ListPlayer;
    public int idPlayerActive;
    public GameObject pointLightHurt;

    [Header("Material")]
    public Material hurtMaterial;
	// Use this for initialization

	void Awake()
	{
        if (instance == null)
        {
            instance = this;
        }
	}

    private void Start()
    {
        Instantiate(ListPlayer[idPlayerActive], transform);
    }

}
