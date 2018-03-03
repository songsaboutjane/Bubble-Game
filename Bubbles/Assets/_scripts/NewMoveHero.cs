using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoveHero :  PhysicsObject {
	public Vector3 startp= new Vector3 (-33.07f, -3.19f, 0); 
	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	public static bool gotKey;

	//private SpriteRenderer spriteRenderer;
	//private Animator animator;

	// Use this for initialization
	void Awake () 
	{
		//spriteRenderer = GetComponent<SpriteRenderer> (); 
		//animator = GetComponent<Animator> ();
	}

	protected override void ComputeVelocity()
	{
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis ("Horizontal");

		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) {
			velocity.y = jumpTakeOffSpeed;
		} else if (Input.GetButtonUp ("Jump")) 
		{
			if (velocity.y > 0) {
				velocity.y = velocity.y * 0.5f;
			}
		}


		targetVelocity = move * maxSpeed;
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("key")) {
			other.gameObject.SetActive (false);
			gotKey=true;
	
		}
		else if (other.gameObject.CompareTag("death")) {
			Respawn();
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "death") {
			Respawn();
			Debug.Log ("Hey");
		}
	}

	void Respawn () {
		transform.position = startp;
	}
}
