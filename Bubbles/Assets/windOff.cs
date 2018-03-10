using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windOff : MonoBehaviour {
	private AreaEffector2D ae2d;

	// Use this for initialization
	void Start () {
		ae2d = GetComponent<AreaEffector2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (leveron.lever == true) {
			Destroy (ae2d);
		}
	}
}
