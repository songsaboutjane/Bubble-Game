using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBubbleIt : MonoBehaviour {
	private Rigidbody2D rb2d;
	private NewMoveHero newmoveHero;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		newmoveHero=GetComponent<NewMoveHero> ();
	}
	
	// Update is called once per frame
	void Update () {}

	void OnTriggerStay2D (Collider2D targ) {
		if (targ.gameObject.tag.Equals ("Bubble") == true && targ.GetType() == typeof(CircleCollider2D)) {
			rb2d.mass = 0.0f;
			newmoveHero.enabled = false;
		} 
	}

	void OnCollisionExit2D () {
		rb2d.mass = 1f;
		newmoveHero.enabled=true;
	}
}
