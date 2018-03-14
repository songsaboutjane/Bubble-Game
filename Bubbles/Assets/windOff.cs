using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windOff : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (leveron.lever == true) {
			Destroy (gameObject);
		}
	}

}
