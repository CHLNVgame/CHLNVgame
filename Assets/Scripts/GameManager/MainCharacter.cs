using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour {

	public static MainCharacter instance;

	private savedata data;

	string UserNameID = "";
	string PassWord = "";



	private int MC_Gold = 500;
	private int MC_Ruby = 500;
	private int MC_PlaneID = 0;
	private int MC_BotLeftID = 0;
	private int MC_BotRightID = 1;

	private int levelPlane;
	private int totalPlane; 
	// 0 disable, enable = level > 0 , 1000 active + level
	private List<int> List_Planes = 			new List<int>(){ 1002,    5,    0,    0,    0,
																	0,    0,    0,    0,    0,
																	0,    0,    0,    0,    0,
																	0,    0}; // default 17 planes
	
	private List<int> List_Planes_Fragment = 	 new List<int>(){   0,     0,    0,    0,    0,
																    0,     0,    0,   0,    0,
												 				    0,     0,    0,    0,    0,
																    0,     0}; // default total Plane

	//private const int totalBot = 5;
	// 0 disable, enable = level > 0, 1000 bot left avtive + level , 2000 bot right active + level
	private List<int> List_Bots = 				new List<int>(){1001, 2001,    1,    0,    0};
	private List<int> List_Bots_Fragment = 		new List<int>(){   0,    0,    0,    0,    0};

	void Awake() {

		if (instance != null)
			return;
		
		instance = this;
		DontDestroyOnLoad (gameObject);
	}

	void setGold( int gold)
	{
		MC_Gold = gold;
	}

	public int getGold()
	{
		return MC_Gold;
	}

	void setRuby(int ruby)
	{
		MC_Ruby = ruby;
	}

	public int getRuby()
	{
		return MC_Ruby;
	}

	void setPlaneID( int planeID)
	{
		List_Planes [MC_PlaneID] -= (int)Define.STATUS_PLANE.ACTIVE;
		List_Planes [planeID] += (int)Define.STATUS_PLANE.ACTIVE;
		MC_PlaneID = planeID;

	}

	public int getPlaneID()
	{
		return MC_PlaneID;
	}

	void setBotLeftID( int botLeftID)
	{
		List_Bots [MC_BotLeftID] -= (int)Define.STATUS_BOT.ACTIVE_LEFT;
		List_Bots [botLeftID] += (int)Define.STATUS_BOT.ACTIVE_LEFT;
		MC_BotLeftID = botLeftID;
	}

	public int getBotLeftID()
	{
		return MC_BotLeftID;
	}

	void setBotRightID( int botRightID)
	{
		List_Bots [MC_BotRightID] -= (int)Define.STATUS_BOT.ACTIVE_RIGHT;
		List_Bots [botRightID] += (int)Define.STATUS_BOT.ACTIVE_RIGHT;
		MC_BotRightID = botRightID;
	}

	public int getBotRightID()
	{
		return MC_BotRightID;
	}

	public void Save()
	{
	//	//Debug.Log (" ++++++++++++ Save Data +++++++++++++++");
		data.MC_Gold = MC_Gold;
		data.MC_Ruby = MC_Ruby;
		data.MC_PlaneID = MC_PlaneID;
		data.MC_BotLeftID = MC_BotLeftID;
		data.MC_BotRightID = MC_BotRightID;
		data.MC_Planes.Clear();
		foreach(int i in List_Planes)
		{
			data.MC_Planes.Add(i);
		}
		data.MC_Bots.Clear();
		foreach(int i in List_Bots)
		{
			data.MC_Bots.Add(i);
		}

		RMS.Save (data);
	}

	public void Load()
	{
	//	//Debug.Log (" ++++++++++++ Load Data +++++++++++++++");
		data = RMS.Load ();
		if (data != null) {
			MC_Gold = data.MC_Gold;
			MC_Ruby = data.MC_Ruby;
			MC_PlaneID = data.MC_PlaneID;
			MC_BotLeftID = data.MC_BotLeftID;
			MC_BotRightID = data.MC_BotRightID;

			List_Planes.Clear ();
			foreach (int i in data.MC_Planes) {
				List_Planes.Add (i);
			}

			List_Bots.Clear ();
			foreach (int i in data.MC_Bots) {
				List_Bots.Add (i);
			}
		}
	}



}
