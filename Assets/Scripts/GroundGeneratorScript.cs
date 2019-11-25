using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneratorScript : MonoBehaviour {

	public GameObject ground;
	public GameObject groundPrefab;

	float unicornPosition;

	public float minGroundY;
	public float maxGroundY;

	public float minGroundSpacing;
	public float maxGroundSpacing;

	public float minGroundScale;
	public float maxGroundScale;

	public void startGeneratingGround(){
		unicornPosition = GameObject.FindWithTag ("UnicornPlayer").GetComponent<Transform>().position.x;

		ground = GameObject.Instantiate (groundPrefab);

		ground.transform.position = new Vector3 (unicornPosition + 10f + Random.Range(minGroundSpacing, maxGroundSpacing), Random.Range(minGroundY, maxGroundY), 0);


	}
}
