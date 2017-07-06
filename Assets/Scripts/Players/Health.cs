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
    private int Bonus;
    private Material normalMaterial;

    LoadPrefabInGame loadPrefab;

    void Start()
	{
        loadPrefab = LoadPrefabInGame.instance;
		// Only enemy have health bar
		if (gameObject.tag != "Player") 
				activeHealthBar = transform.GetChild (0);

        normalMaterial = gameObject.GetComponent<SpriteRenderer>().material;

    }

	public void SeekHealthDamge(int hp, int damge, int bonus)
	{
		HP = hp;
		totalHP = hp;

		Damge = damge;
        Bonus = bonus;
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
			if (healthBar != null)
				healthBar.fillAmount = (float)HP / totalHP;
		}

		if (HP <= 0 || amount == -1) 
		{
			DestroyObject ();
			return;
		}

        if (gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<SpriteRenderer>().material = loadPrefab.hurtMaterial;
            GameObject pointLight = (GameObject)Instantiate(loadPrefab.pointLightHurt, transform);
            pointLight.transform.position += Vector3.back;
            DestroyObject(pointLight, 0.1f);
            Invoke("ReturnNormalMaterial", 0.2f);
        }
	}

    void ReturnNormalMaterial()
    {
        gameObject.GetComponent<SpriteRenderer>().material = normalMaterial;
   //     pointLight.SetActive(false);
    }


	void DestroyObject()
	{

        if (gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            CreateBonus();
        }
       // int temp = Random.Range (0, LoadPrefabInGame.instance.listExplosion.Length);
     //   if(ListEffectDestroy[0] != null)
        		Instantiate (loadPrefab.listExplosion[0], transform.position, Quaternion.identity);

        
	}

    void CreateBonus()
    {
        int idBonus = 0;
        int randomBonus = Random.Range(0, 100);
        if (randomBonus < 100)
            idBonus = 0;

        if (idBonus == 0) //coin small
        {           
            for (int i = 0; i < Bonus; i++)
            {
                
                Vector3 pos = transform.position;
                float max = pos.x + 1;
                float min = pos.x - 1;
                pos.x = Random.Range(min, max);
                Instantiate(loadPrefab.listBonus[idBonus], pos, Quaternion.identity);
            }
        }
    }

}
