using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour {
	public float speed;
	public Color rayColor = Color.white;
	public List<Transform> path_Objects = new List<Transform>();
	Transform[] array_Ojbects;
	void OnDrawGizmos()
	{
		Gizmos.color = rayColor;
		array_Ojbects = GetComponentsInChildren<Transform> ();
		path_Objects.Clear ();
		foreach (Transform path_Obj in array_Ojbects) {
			if (path_Obj != this.transform) {
				path_Objects.Add (path_Obj);			
			}
		}
		for (int i = 0; i < path_Objects.Count; i++) {
			Vector3 pos = path_Objects [i].position;
			if (i > 0) {
				Vector3 prevPos = path_Objects [i - 1].position;
				Gizmos.DrawLine (prevPos, pos);
				Gizmos.DrawSphere (pos, 0.3f);
			}
		}
	}
	void Update()
	{
		transform.position += Vector3.up * speed * Time.deltaTime;
	}
}
