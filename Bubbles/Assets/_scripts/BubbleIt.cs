using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleIt : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float mass = 1f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		//rb2d.mass = mass;
		
	}

	void OnTriggerStay2D (Collider2D targ) {
		
		if(targ.gameObject.tag.Equals("Bubble") == true ){
			rb2d.mass = 0.0f;

		}

	}


}
