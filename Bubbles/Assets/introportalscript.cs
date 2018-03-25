using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introportalscript : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (onpush.ispushed == false) {
			anim.SetTrigger ("ON");
			Debug.Log ("ON");
		}
		else if (onpush.ispushed == true) {
			anim.SetTrigger ("OFF");
			Debug.Log ("off");
		}
	}
}
