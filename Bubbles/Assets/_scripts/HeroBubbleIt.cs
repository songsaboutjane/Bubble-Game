using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBubbleIt : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float mass = 1f;
	private MoveHero moveHero;
	private bool inBubble = false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		moveHero=GetComponent<MoveHero> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (inBubble == false) {
			rb2d.mass = mass;
		}
		moveHero.enabled=true;
	}

	void OnTriggerStay2D (Collider2D targ) {
		
		if (targ.gameObject.tag.Equals ("Bubble") == true) {
			inBubble = true;
			rb2d.mass = 0.0f;
			moveHero.enabled = false;

		} else {
			inBubble = false;
		}

	}


}
