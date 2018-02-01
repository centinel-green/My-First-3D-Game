using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
	//keeps count of score in the map.
	[SerializeField]
	public static int CoinCount = 0;
	// Use this for initialization
	void Start () {
		//Object creates, increment ScoreCount.
		CoinCount++;

	}

	void OnTriggerEnter(Collider col){
		//If the object that will collide with the coin is player, the coin should be destroyed.
		if (col.CompareTag ("Player"))
			Destroy (gameObject);
	}
	void OnDestroy() {
		//Since the point no longer exists, ie it is destroyed, we remove it from the total number of the coins we have in game.
		--Point.CoinCount;
		if (Point.CoinCount <= 0) {
						
		 //We will have won the game because the objective is to collect all the coins, before being caught by the enemies.
		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (CoinCount);
	}
}
