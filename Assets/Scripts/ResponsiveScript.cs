using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apply this class to the background and make every GameObject his children to make it work 
//(it deforms the sprites but was the best solution i've fount for this)

public class ResponsiveScript : MonoBehaviour {

	//Methos called when the game starts (unity library)
	void Start(){

		//creates a variable to get the sprite renderer
		SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
		Transform scaleX = GetComponent<Transform> ();

		//create float variables to receive the width and height of the sprite renderer
		float width = scaleX.localScale.x;
		float height = renderer.sprite.bounds.size.y;

		//sets the scale of the sprite to x = 1, y = 1, z = 1
		transform.localScale = new Vector3 (width, 1f, 1f);

		//create a float variable to represent the screen height wich receives twice the size of the camera
		float worldScreenHeight = Camera.main.orthographicSize * 2f;

		//create a float variable to represente the screen width, 
		//it receives height and divides it by the screen height times the screen width
		//float worldScreenWidth = worldScreenHeight / Screen.height*Screen.width;

		//create a vector3 variable with captures the current scale of the sprite, then sets it's x axis to a division 
		//between the screen width and the camera width, then sets the sprite scale to this new width
		/*Vector3 xWidth = transform.localScale;
		xWidth.x = worldScreenWidth / width;
		transform.localScale = xWidth;*/

		//does the same thing as the code above but for height
		Vector3 yHeight = transform.localScale;
		yHeight.y = worldScreenHeight / height;
		transform.localScale = yHeight;
	}
}
