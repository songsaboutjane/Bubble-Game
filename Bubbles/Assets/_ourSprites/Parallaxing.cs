﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

	public Transform[] backgrounds;		//Array of all the backgrounds to be parralaxed
	private float[] parallaxScales;		//The proportion of the camera's movement to move the background by
	public float smoothing = 1f;		//How smooth the parralax is going to be (Make sure to set >0)

	private Transform cam; 				//Reference to the main cameras transform
	private Vector3 previousCamPos;		//Store the postion of the camera in the previous frame

	//Is called before Start (). Great for references
	void Awake () {
		//set up the camera reference
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {
		//The previous frame at the current frames camera position
		previousCamPos = cam.position;

		//Assigning corresponding parallax scales
		parallaxScales = new float[backgrounds.Length];
		for (int i = 0; i < backgrounds.Length; i++) {
			parallaxScales [i] = backgrounds[i].position.z*-1;

		}
	}
	
	// Update is called once per frame
	void Update () {
		//for each background
		for(int i = 0; i < backgrounds.Length; i++){
			//parallax is opposite of the camera movement because the previous frame is multiplied by the scale
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

			//set a target x position which is the current position plus the parallax
			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			//create a target position which is the backgrounds current position with it's target x position
			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

			//fade between current position and the target position using lerp
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		}
		// set previous cam pos to the cam position at the end of the frame
		previousCamPos = cam.position;
	}
}
