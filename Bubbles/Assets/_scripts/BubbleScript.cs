using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleScript : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float upForce= 1f;
	private float rand=0f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {//too laggy and doesnt really work that well
		rand = rand + Random.Range (-0.2f, 0.2f);
		
		rb2d.MovePosition (rb2d.position + new Vector2 (rand, upForce) * Time.fixedDeltaTime);

	}
}
