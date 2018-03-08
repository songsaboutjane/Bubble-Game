using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockLock : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (NewMoveHero.gotKey == true) {
			anim.SetTrigger ("unlocked");
		}
	}
}
