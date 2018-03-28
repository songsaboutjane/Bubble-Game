using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introPortal : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (onpush.ispushed == true) {
			anim.SetTrigger ("OFF");
		}
		else {
			anim.SetTrigger ("ON");
		}
	}
}
