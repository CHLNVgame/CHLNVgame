using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMc01 : BulletManager {

	void Update()
	{
        transform.Translate(Vector3.up * Speed * Time.deltaTime, Space.World);
	}
}
