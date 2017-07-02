using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Image healthBar;

	private Transform activeHealthBar;

	private int Damge;
	private int HP;
	private int totalHP;

	[SerializeField] private GameObject[] ListEffectDestroy = null;
	[SerializeField] private GameObject[] Items = null;
	void Start()
	{
		// Only enemy have health bar
		if (gameObject.tag != "Player") 
				activeHealthBar = transform.GetChild (0);
	}

	public void SeekHealthDamge(int hp, int damge)
	{
		HP = hp;
		totalHP = hp;

		Damge = damge;
	}

	void OnTriggerEnter2D(Collider2D target) 
	{
		if (gameObject.tag == "Player") 
		{
			if (target.tag == "Enemy") {
				Health health = target.GetComponent<Health> ();
				if(health != null)
					health.TakeDame (-1); // -1 to Destroy enemy;
			}
		}
		else
		{
		
			if (target.tag == "DestroyEnemies") {
				DestroyObject ();     
			}

			if (target.tag == "Player") {

				Health health = target.GetComponent<Health> ();
				if(health != null)
					health.TakeDame (Damge);
			}

		}

	}

	public void TakeDame(int amount)
	{
		HP -= amount;
		if (HP < 0)
			HP = 0;
		
		if (gameObject.tag == "Player") {
			GamePlayController.instance.seekHP (HP, false);
		}
		else
		{
			if (activeHealthBar != null)
				activeHealthBar.gameObject.SetActive (true);
//			//Debug.Log (" 22222222222222222 ");
			if (healthBar != null)
				healthBar.fillAmount = (float)HP / totalHP;
		}

		if (HP <= 0 || amount == -1) 
		{
			DestroyObject ();
			return;
		}
	}


	void DestroyObject()
	{
		
		if (gameObject.tag == "Boss") {
			GamePlayController.instance.SetGameEndGame (true);
			GamePlayController.instance.SetGameVictory (true);
		}
		if(gameObject.tag == "Enemy")
			
		Destroy (gameObject);
		//int temp = Random.Range (0, ListEffectDestroy.Length);
		if(ListEffectDestroy[0] != null)
			Instantiate (ListEffectDestroy[0], transform.position, Quaternion.identity);
		if (Items != null) {
			for (int i = 0; i < Items.Length; i++) {
				Vector3 pos = transform.position;
				float max = pos.x + 1;
				float min = pos.x - 1;
				pos.x = Random.Range (min, max);
				Instantiate (Items[i], pos, Quaternion.identity);
			}
		}
	}

}
