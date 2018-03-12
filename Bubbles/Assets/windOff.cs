using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windOff : MonoBehaviour {
	private AreaEffector2D ae2d;
	public float force;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if (leveron.lever == true) {
			Destroy (gameObject);
		}
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.CompareTag("weighted") || col.gameObject.CompareTag("Bubble")) {
			Debug.Log ("Heyo");
			col.attachedRigidbody.AddForce (new Vector2 (force, 0));
		}
	
	}
}
