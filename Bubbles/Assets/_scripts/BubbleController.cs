using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float range = 0.5f;
	public float lrForce = 5f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		rb2d.AddForce (new Vector2 (Random.Range (-range, range), 0));
		var bubblePosition = Camera.main.WorldToScreenPoint(transform.position);
		var direction = Input.mousePosition - bubblePosition;
		var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		if (angle > 90 || angle <= -90) {
			rb2d.AddForce (new Vector2 (-lrForce, 0));
		}
		else if (angle <= 90 || angle > -90) {
			rb2d.AddForce (new Vector2 (lrForce, 0));
		}
	}

	void OnCollisionEnter2D (Collision2D hit) {
		if (hit.gameObject.tag.Equals ("spikes") == true || hit.gameObject.tag.Equals ("spikedeath") == true) {
			Destroy (gameObject);
			MakingBubbles.bubbleCount=MakingBubbles.bubbleCount -1;
		}
	}
}