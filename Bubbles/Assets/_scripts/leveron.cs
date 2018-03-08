using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveron : MonoBehaviour {

	public static bool lever = false;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D touch){
		if (touch.gameObject.CompareTag ("weighted") && NewMoveHero.gotKey) {
			anim.SetTrigger ("move");
			lever = true;
		}
	}
	// Update is called once per frame
	void Update () {
	}
}
