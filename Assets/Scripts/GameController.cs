using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameObject player;

	void Start () {
		GameController.player = GameObject.Find("Player");
	}
	
	void Update () {
		
	}
}
