using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftScript : MonoBehaviour {
	public Vector3 new_postion;

	// Use this for initialization
	void Start () {
		new_postion.Set (77.033f, 0.84f, -1f);	
	}
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("Left Working");
		collider.transform.position = new_postion;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
