using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onpush : MonoBehaviour {
	public static bool ispushed;

	void OnCollisionStay2D (Collision2D hit) {
		if (hit.gameObject.tag.Equals ("weighted") == true || hit.gameObject.tag.Equals ("Player") == true) {
			ispushed = true;
		} 
	}
	
	void OnCollisionExit2D (Collision2D hit) {
		ispushed = false;
	}
}
