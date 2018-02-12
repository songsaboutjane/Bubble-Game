using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {
	//public static bool gotKey;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter() {
		Destroy (gameObject); 
		//gotKey = true;
	}


}
