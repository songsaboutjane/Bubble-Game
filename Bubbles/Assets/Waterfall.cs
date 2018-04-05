using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterfall : MonoBehaviour {
	public float force;
	public GameObject bridge;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - bridge.transform.position;
	}

	// Update is called once per frame

	void Update () {
		transform.position = bridge.transform.position + offset;

	}

	void OnTriggerStay2D (Collider2D col) {
		if (col.gameObject.tag.Equals ("Bubble")) {
			col.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
		}
	}
}