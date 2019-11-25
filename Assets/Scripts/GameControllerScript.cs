using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

	//Calling all game objects
	public GameObject playerController;
	public GameObject cameraController;
	public GameObject mapGeneratorController;
	public GameObject responsiveController;

	void Start () {
		playerController.GetComponent<PlayerScript> ().playerStartSetUp ();
		mapGeneratorController.GetComponent<MapGeneratorScript> ().firstScenarioGeneration ();
	}

	void Update () {
		playerController.GetComponent<PlayerScript> ().playerJump ();
		cameraController.GetComponent<CameraScript> ().cameraForwardImpulse ();
	}

	void FixedUpdate() {
		cameraController.GetComponent<CameraScript> ().CameraMovement ();
		mapGeneratorController.GetComponent<MapGeneratorScript> ().buildNextScenario ();
	}
}
