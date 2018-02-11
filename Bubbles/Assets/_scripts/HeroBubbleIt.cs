using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBubbleIt : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float mass = 1f;
	private NewMoveHero newmoveHero;
	private bool inBubble = false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		newmoveHero=GetComponent<NewMoveHero> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (inBubble == false) {
			rb2d.mass = mass;
			newmoveHero.enabled=true;
		}
		//newmoveHero.enabled=true;
	}

	void OnTriggerStay2D (Collider2D targ) {
		if (targ.gameObject.tag.Equals ("Bubble") == true && targ.GetType() == typeof(CircleCollider2D)) {
			inBubble = true;
			rb2d.mass = 0.0f;
			newmoveHero.enabled = false;
			Debug.Log ("Touched the bubble");

		} 
		else {
			inBubble = false;
			newmoveHero.enabled=true;
			Debug.Log("HEre");
		}

	}
	void OnCollisionEnter2D () {
		newmoveHero.enabled=true;
	}


}
