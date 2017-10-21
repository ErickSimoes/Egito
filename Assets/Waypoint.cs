using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

	Vector3 localScale;
	Vector3 localPosition;

	private void Start() {
		localScale = transform.localScale;
		localPosition = transform.localPosition;
	}

	public void Click() {
		GameController.player.transform.position = localPosition;
	}

	public void MouseHover(bool enter) {
		if (enter) {
			transform.localScale = new Vector3(.1f, .1f, .1f) + localScale;
			GetComponent<ParticleSystem>().Play();
		} else {
			transform.localScale = localScale;
			GetComponent<ParticleSystem>().Stop();
		}
	}
}
