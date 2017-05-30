using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMS : MonoBehaviour {


	public static void Save(savedata data)
	{
		if (!Directory.Exists (Application.dataPath + "/SaveLoad"))
			Directory.CreateDirectory (Application.dataPath + "/SaveLoad");

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.dataPath + "/SaveLoad/RMS.dat");

		bf.Serialize (file, data);
		file.Close ();
	}

	public static savedata Load()
	{
		savedata data;
		if (File.Exists (Application.dataPath + "/SaveLoad/RMS.dat")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.dataPath + "/SaveLoad/RMS.dat", FileMode.Open);
			data = (savedata)bf.Deserialize (file);
			file.Close ();
			return data;
		}

		return null;
	}

}

[System.Serializable]
public class savedata
{
	public int MC_Gold = 0 ;
	public int MC_Ruby = 0;
	public int MC_PlaneID = 0;
	public int MC_BotLeftID = 0;
	public int MC_BotRightID = 1;
	public List<int> MC_Planes = new List<int> ();
	public List<int> MC_Bots = new List<int>();
}
