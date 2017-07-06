using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform[] listGun;
//	public Transform midGun;
	//public Transform rightGun;
	public Transform leftBot;
	public Transform rightBot;

	public Transform posStart;

	private float speedMoveKey = 2;

	private int ClassPlayer;
    private float Speed = 6;
	private float SpeedAuto = 10;
	private int HP;
	private int Damge;
	private int DamgeSpecial;
	private float FireRate;
	private int SpeedBullet;
	private int damgePerBullet;




    //	private Rigidbody2D bodyPlayer; // Control Player
    float minX, maxX, minY, maxY, moveX, moveY, PlayerWidth, PlayerHeight;
	Vector2 posTouch, posTouchMove;
	bool mouseControl = false;

	[SerializeField] private GameObject bullet = null;
	[SerializeField] private GameObject[] ListBot = null;

	private int idPlane;
	private int idLeftBot;
	private int idRightBot;

	private BotPlayer leftBotPlayer;
	private BotPlayer rightBotPlayer;

	bool canShoot = true;
	float timerControl;
	float timerStart;
	Vector3 possStart;
	void Awake() {

		//InitPlayer ();

	}


	void InitPlayer()
	{
		idPlane    = MainCharacter.instance.getPlaneID ();
		idLeftBot  = MainCharacter.instance.getBotLeftID ();
		idRightBot = MainCharacter.instance.getBotRightID ();

		if (idLeftBot != -1) {
			GameObject leftObject = (GameObject) Instantiate (ListBot [idLeftBot], Define.LEFT_BOT_POS, Quaternion.identity);
			leftBotPlayer = leftObject.GetComponent<BotPlayer> ();
		}

		if (idRightBot != -1) {
			GameObject rightObject = (GameObject) Instantiate (ListBot [idRightBot], Define.RIGHT_BOT_POS, Quaternion.identity);
			rightBotPlayer = rightObject.GetComponent<BotPlayer> ();
		}

		ClassPlayer = Attributes.PLANE_ATT [idPlane, Attributes.CLASS_PLANE];
        HP = Attributes.PLANE_ATT[idPlane, Attributes.HP_PLANE];
		Damge = Attributes.PLANE_ATT[idPlane, Attributes.DAMGE_PLANE];
		DamgeSpecial = Attributes.PLANE_ATT[idPlane, Attributes.DAMGE_SPEC_PLANE];
		FireRate = (float ) 1 / Attributes.PLANE_ATT[idPlane, Attributes.FIRE_RATE_PLANE];
		SpeedBullet = Attributes.PLANE_ATT[idPlane, Attributes.SPEED_BULLET_PLANE];


		Health health = GetComponent<Health> ();

		if(health != null)
            health.SeekHealthDamge(HP, 0, 0); // Function only add damge  and bonus for enemy
        GamePlayController.instance.seekHP (HP, true);
	}

	// Use this for initialization
	void Start () {		
		InitPlayer ();
		damgePerBullet = Damge/listGun.Length;

	//	bodyPlayer = GetComponent<Rigidbody2D> ();
		Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
		Sprite spPlayer = GetComponent<SpriteRenderer> ().sprite;
		PlayerWidth = spPlayer.bounds.min.x * transform.localScale.x;
		PlayerHeight = spPlayer.bounds.min.y * transform.localScale.y;
		minX = -bounds.x - PlayerWidth;
		maxX = bounds.x + PlayerWidth;
		minY = -bounds.y - PlayerHeight;
		maxY = bounds.y + PlayerHeight;
		timerStart = Time.time + Define.GAMEPLAY_TIMER_START;
		possStart = transform.position;
	}

	// Update is called once per frame
	void Update () {
	//	moveX = Input.GetAxis ("Horizontal") * speedMoveKey; // Control by key A & D or Left right
	//	moveY = Input.GetAxis ("Vertical") * speedMoveKey; // control by key W &S up down
	//	bodyPlayer.velocity = new Vector2 (moveX, moveY); // Input velocity for Player.
    /*
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

        if (mouseControl) {
            moveX = (posTouchMove.x - posTouch.x);
            moveY = (posTouchMove.y - posTouch.y);
            transform.Translate (moveX, moveY, 0, Space.World);
            posTouch.x = posTouchMove.x;
            posTouch.y = posTouchMove.y;

        } 

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
        */
		if(leftBotPlayer != null)
			leftBotPlayer.SeekPosition (leftBot);
		if(rightBotPlayer != null)
			rightBotPlayer.SeekPosition (rightBot);
		if (Time.time < GamePlayController.instance.GetTimerControll()) {
			transform.position = Vector3.MoveTowards (transform.position, posStart.position, SpeedAuto * Time.deltaTime);
			return;
		}
		if (GamePlayController.instance.GetGameVictory ()) {
			if(Time.time > GamePlayController.instance.GetTimerControll() + 0.5f)
				transform.position += Vector3.up* SpeedAuto*2 * Time.deltaTime;
			return;
		}

		if (Input.GetMouseButton (0)) {
			posTouch = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            Vector2 posViewPort = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            float offsetPos;
		    if (posViewPort.y <= 0.5f)
				offsetPos = posViewPort.y * 4;
            else
                offsetPos = 4 - posViewPort.y * 4;
			posTouch.y += offsetPos;

			transform.position = Vector3.Lerp (transform.position, posTouch, Time.deltaTime * Speed);
		}
		if(canShoot)
			StartCoroutine (shoot());
	}
	IEnumerator shoot() {
		canShoot = false;

		for (int i = 0; i < listGun.Length; i++) 
		{
			GameObject bull = (GameObject) Instantiate (bullet, listGun[i].position, Quaternion.identity);
	
			BulletManager bulletmanager = bull.GetComponent<BulletManager> ();
			if (bulletmanager != null) 
				bulletmanager.SeekSpeedDamge (SpeedBullet, damgePerBullet, true);
		}
		yield return new WaitForSeconds (FireRate);
		canShoot = true;
	}

}
