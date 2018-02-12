using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTotem : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float maxh=0f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (onpush.ispushed == true) {
			rb2d.MovePosition (rb2d.position + new Vector2 (0, -2) * Time.fixedDeltaTime);
		}
	}
}
