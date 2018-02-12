using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onpush : MonoBehaviour {
	public static bool ispushed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D (Collision2D hit) {
		if (hit.gameObject.tag.Equals ("weighted") == true) {
			ispushed = true;
		} else {
			ispushed = false;
		}
	}
}
