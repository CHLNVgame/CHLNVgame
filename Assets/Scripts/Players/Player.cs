using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public static Player Instance;

	public Transform[] listGun;
//	public Transform midGun;
	//public Transform rightGun;
	public Transform leftBot;
	public Transform rightBot;

	private float speedMoveKey = 2;

	private int ClassPlayer;
	private int HP;
	private int Damge;
	private int DamgeSpecial;
	private float FireRate;


	private Rigidbody2D bodyPlayer; // Control Player
	float minX, maxX, minY, maxY, moveX, moveY, PlayerWidth, PlayerHeight;
	Vector2 posTouch, posTouchMove;
	bool mouseControl = false;

	private Animator anim;
	bool turnLeft = false;
	bool turnRight = false;
	bool turnLeftBack = false;
	bool turnRightBack = false;

	string lastAnim;
	string currAnim;

	[SerializeField] private GameObject bullet = null;
	[SerializeField] private GameObject[] ListBot = null;

	private int idPlane;
	private int idLeftBot;
	private int idRightBot;

	bool canShoot = true;
	void Awake() {
		if (Instance != null)
			Destroy (gameObject);
		else {
			Instance = this;
			DontDestroyOnLoad (gameObject);
		}


		InitPlayer ();

	}


	void InitPlayer()
	{
		idPlane    = MainCharacter.Instance.getPlaneID ();
		idLeftBot  = MainCharacter.Instance.getBotLeftID ();
		idRightBot = MainCharacter.Instance.getBotRightID ();

		if(idLeftBot != -1)
			Instantiate (ListBot[idLeftBot], Define.LEFT_BOT_POS , Quaternion.identity);

		if(idRightBot != -1)
			Instantiate (ListBot[idRightBot], Define.RIGHT_BOT_POS, Quaternion.identity);

		ClassPlayer = Attributes.PLANE_ATT [idPlane, Attributes.CLASS_PLANE];
		HP = Attributes.PLANE_ATT[idPlane, Attributes.HP_PLANE];
		Damge = Attributes.PLANE_ATT[idPlane, Attributes.DAMGE_PLANE];
		DamgeSpecial = Attributes.PLANE_ATT[idPlane, Attributes.DAMGE_SPEC_PLANE];
		FireRate = (float ) 1 / Attributes.PLANE_ATT[idPlane, Attributes.FIRE_RATE_PLANE];
		
	}

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		bodyPlayer = GetComponent<Rigidbody2D> ();
		Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
		Sprite spPlayer = GetComponent<SpriteRenderer> ().sprite;
		PlayerWidth = spPlayer.bounds.min.x * transform.localScale.x;
		PlayerHeight = spPlayer.bounds.min.y * transform.localScale.y;
		minX = -bounds.x - PlayerWidth;
		maxX = bounds.x + PlayerWidth;
		minY = -bounds.y - PlayerHeight;
		maxY = bounds.y + PlayerHeight;
		lastAnim = "normal";
		currAnim = "normal";
	}

	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis ("Horizontal") * speedMoveKey; // Control by key A & D or Left right
		moveY = Input.GetAxis ("Vertical") * speedMoveKey; // control by key W &S up down
		bodyPlayer.velocity = new Vector2 (moveX, moveY); // Input velocity for Player.

		// Control by mouse;
		if (Input.GetMouseButton (0)) {
			posTouchMove = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//mouseControl = true;
		}
		if (Input.GetMouseButtonDown (0)) {
			posTouch = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouseControl = true;
		}
		if (Input.GetMouseButtonUp (0)) {
			mouseControl = false;
		}
		// dont use
		//Control by Touch 
		/*int nbTouches = Input.touchCount;
		if (nbTouches > 0) {
			Touch touch = Input.GetTouch (0);
			TouchPhase phase = touch.phase;
			switch(phase) {
				case TouchPhase.Began:
				break;
				case TouchPhase.Moved:
				break;
				case TouchPhase.Stationary:
				break;
				case TouchPhase.Ended:
				break;
				case TouchPhase.Canceled:
				break;
			}
		}*/


		if (mouseControl) {
			moveX = (posTouchMove.x - posTouch.x);
			moveY = (posTouchMove.y - posTouch.y);
			transform.Translate (moveX, moveY, 0, Space.World);
			posTouch.x = posTouchMove.x;
			posTouch.y = posTouchMove.y;

		} 

		updateAnimPlane ();

		Vector3 tempPosition = transform.position;
		if (tempPosition.x < minX)
			tempPosition.x = minX;
		else if (tempPosition.x > maxX)
			tempPosition.x = maxX;
		if (tempPosition.y < minY)
			tempPosition.y = minY;
		else if (tempPosition.y > maxY)
			tempPosition.y = maxY;

		transform.position = tempPosition;
		if(canShoot)
			StartCoroutine (shoot());
	}
	IEnumerator shoot() {
		canShoot = false;

		for (int i = 0; i < listGun.Length; i++) 
		{
			Instantiate (bullet, listGun[i].position, Quaternion.identity);
		}
		yield return new WaitForSeconds (FireRate);
		canShoot = true;
	}
		
	void OnTriggerEnter2D(Collider2D target) {
		if (target.tag == "Enemy") {
			Destroy (target.gameObject);
		}
	}
	public int GetAttack() {
		return Damge;
	}

	void updateAnimPlane ()
	{
		if (moveX < 0) {
			currAnim = "left";
		} 

		if(moveX > 0){
			currAnim = "right";
		}

		if (moveX == 0) 
		{
			if (lastAnim.Equals("left"))
			{
				currAnim = "leftback";
			}
			if (lastAnim.Equals("right"))
			{
				currAnim = "rightback";
			}
		}
		if (currAnim != lastAnim) 
		{
			lastAnim = currAnim;
			anim.Play (currAnim);
		}
	}

}
