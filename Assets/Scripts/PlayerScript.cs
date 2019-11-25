using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public GameObject UnicornPlayer;
	public Collider2D collide;

	public Rigidbody2D playerPhisycs;
	float jumpForce = 300f;
	public bool isInTheAir = false;

	public float gravityMultiplierWhileFalling = 6.5f;
	public float gravityMultiplierLowJump = 6f;

	public void playerStartSetUp() {
		
		playerPhisycs = GetComponent<Rigidbody2D> ();
	}

	public void playerJump() {
		
		if (isInTheAir == false) {

			if (Input.GetKeyDown (KeyCode.Space)) {

				playerPhisycs.AddForce (transform.up * jumpForce);
			}
		}

		jumpCalibration ();
	}

	void jumpCalibration(){

		if (playerPhisycs.velocity.y < 0){
			playerPhisycs.velocity += Vector2.up * Physics2D.gravity.y * (gravityMultiplierWhileFalling - 1) * Time.deltaTime;
		} else if(playerPhisycs.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
			playerPhisycs.velocity += Vector2.up * Physics2D.gravity.y * (gravityMultiplierLowJump - 1) * Time.deltaTime;
		}

	}

	public void OnCollisionEnter2D(Collision2D other) {
		
		if (other.gameObject.tag == "Ground") {
			isInTheAir = false;
		} 
	}

	public void OnCollisionExit2D(Collision2D other) {
		
		if (other.gameObject.tag == "Ground") {
			isInTheAir = true;
		}
	}
}
