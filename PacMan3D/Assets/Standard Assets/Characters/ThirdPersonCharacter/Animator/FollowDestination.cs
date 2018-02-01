using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent ThisAgent = null;
	public Transform Destination = null;

	// Use this for initialization
	void Start () {
		ThisAgent = GetComponent<UnityEngine.AI.NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		ThisAgent.SetDestination (Destination.position);
	}
}
