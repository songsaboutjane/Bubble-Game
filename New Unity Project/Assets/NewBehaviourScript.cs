using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour {
	public float jumpForce= 200f;
	public float moveForce= 5f;
	private Rigidbody2D rb2d;

	private bool onGround=false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) && onGround==true){
			rb2d.velocity=Vector2.zero;
			rb2d.AddForce(new Vector2(0, jumpForce));
			//rb2d.MovePosition(rb2d.position+new Vector2(0, jumpForce)); //doesn't work
			onGround = false;

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			//rb2d.MovePosition (rb2d.position + new Vector2 (moveForce, 0));
			rb2d.AddForce(new Vector2(moveForce, 0));

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			//rb2d.MovePosition (rb2d.position + new Vector2 (-(moveForce), 0));
			rb2d.AddForce(new Vector2(-(moveForce), 0));

		}


	}
	void OnCollisionEnter2D () {
		onGround = true;

	}
}