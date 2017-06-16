using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Image healthBar;

	private Transform activeHealthBar;

	private int HP;
	private int totalHP;

	[SerializeField] private GameObject[] ListEffectDestroy = null;

	void Start()
	{
		activeHealthBar = transform.GetChild (0);
	}

	public void SetHealth(int hp)
	{
		HP = hp;
		totalHP = hp;
	}

	void OnTriggerEnter2D(Collider2D target) 
	{
		if (target.tag == "DestroyEnemies")
		{
			DestroyObject ();     
		}

		if (target.tag == "BulletPlayer")
		{
			TakeDame (1);
		} 

	}

	public void TakeDame(int amount)
	{
		HP -= amount;
		if (HP <= 0) 
		{
			DestroyObject ();
			return;
		}
		Debug.Log (" 111111111111111111 HP: "+HP);
		if(activeHealthBar != null)
			activeHealthBar.gameObject.SetActive (true);
		Debug.Log (" 22222222222222222 ");
		if(healthBar != null)
			healthBar.fillAmount = (float)HP/totalHP;
	}


	void DestroyObject()
	{
		if (gameObject.tag == "Boss")
			GamePlayController.instance.ShowVictoryPanel();
		Destroy (gameObject);
		//int temp = Random.Range (0, ListEffectDestroy.Length);
		Instantiate (ListEffectDestroy[0], transform.position, Quaternion.identity);
	}

}
