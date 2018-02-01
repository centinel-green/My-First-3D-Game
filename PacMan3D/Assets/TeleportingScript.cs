using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingScript : MonoBehaviour {
	public Vector3 new_position;

		// Use this for initialization
	void Start () {
		new_position.Set (-64.67f, 0.85f, 1.9777f);	
	}
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.name == "Player")
			Debug.Log ("Right Working");
		
		collider.transform.position = new_position ;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
