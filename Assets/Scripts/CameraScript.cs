using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject getVariblesFromPlayerScript;
	float playerSpeed = 0.08f;
	float dashSpeed = 5f;


	public void CameraMovement(){

		Camera mainCamera = GetComponent<Camera> ();

		mainCamera.transform.position += new Vector3  (1f * playerSpeed, 0f, 0f);
	}

	public void cameraForwardImpulse(){

		Camera mainCamera = GetComponent<Camera> ();

		if (Input.GetKey(KeyCode.D) && getVariblesFromPlayerScript.GetComponent<PlayerScript>().isInTheAir == true) {
			mainCamera.transform.position += transform.right * dashSpeed * Time.deltaTime;
		}
	}
}