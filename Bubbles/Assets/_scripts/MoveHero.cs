using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour {
	public float jumpForce= 100f;
	public float moveForce= 0.1f;
	private Rigidbody2D rb2d;
	public Rigidbody2D bubblePrefab;

	private bool onGround=false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow) && onGround==true){
			rb2d.velocity=Vector2.zero;
			rb2d.AddForce(new Vector2(0, jumpForce));
			//rb2d.MovePosition(rb2d.position+new Vector2(0, jumpForce)); //doesn't work
			onGround = false;

		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (onGround == false) {
				rb2d.AddForce (new Vector2 (moveForce, 0));
			}
			else {
				rb2d.MovePosition (rb2d.position + new Vector2 (moveForce, 0) * Time.fixedDeltaTime);
				//rb2d.AddForce (new Vector2 (moveForce, 0));
			}
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (onGround == false) {
				rb2d.AddForce (new Vector2 (-moveForce, 0));
			}
			else {
				rb2d.MovePosition (rb2d.position + new Vector2 (-moveForce, 0) * Time.fixedDeltaTime);
				//rb2d.AddForce (new Vector2 (-moveForce, 0));
			}
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			rb2d.velocity=Vector2.zero;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			rb2d.velocity=Vector2.zero;
		}

	}
	void OnCollisionEnter2D () {
		onGround = true;
		rb2d.velocity=Vector2.zero;
	}

	void OnCollisionExit2D () {
		onGround = false;
	}
}
