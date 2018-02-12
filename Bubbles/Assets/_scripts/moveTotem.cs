using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTotem : MonoBehaviour {
	private Rigidbody2D rb2d;
	private float count = 100f; 
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (onpush.ispushed == true) {
			if (count > 84) {
				rb2d.MovePosition (rb2d.position + new Vector2 (0, -0.05f));
				count -= 0.05f;
			}
		}
		else if (onpush.ispushed == false) {
			if (count < 100) {
				rb2d.MovePosition (rb2d.position + new Vector2 (0, 0.1f));
				count += 0.1f;
			}
		}
	}
}
