using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBubbleScript : MonoBehaviour {
	private Rigidbody2D rb2d;
	private WheelJoint2D joint; 
	public float range = 0.5f;
	public float lrForce = 5f;
	public static bool Collision = false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		joint = GetComponent<WheelJoint2D> (); //use this to hold things somehow
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.AddForce (new Vector2 (Random.Range (-range, range), 0));
		if (Input.GetKey (KeyCode.A)) {
			rb2d.AddForce (new Vector2 (-(lrForce), 0));
			
		}
		if (Input.GetKey (KeyCode.D)) {
			rb2d.AddForce (new Vector2 (lrForce, 0));

		}
		if (MakingBubbles.pickup != null) {
			joint.anchor = transform.position;
			joint.connectedBody = MakingBubbles.pickup.GetComponent<Rigidbody2D>();
		}

	}
	void OnMouseDown(){
		Destroy (gameObject);
		MakingBubbles.bubbleCount=MakingBubbles.bubbleCount -1;
	
	}

	void OnCollisionEnter2D() {
		Collision = true;
	}



		
}