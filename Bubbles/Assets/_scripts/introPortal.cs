using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	void OnTriggerStay2D(Collider2D col) {
		if (onpush.ispushed == false && col.gameObject.CompareTag("Player")) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene ("Level1");
			}
		}
	}
}
