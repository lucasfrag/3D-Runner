// Smooth Follow from Standard Assets
// Converted to C# because I fucking hate UnityScript and it's inexistant C# interoperability
// If you have C# code and you want to edit SmoothFollow's vars ingame, use this instead.
using UnityEngine;
using System.Collections;

public class smoothFollowScript : MonoBehaviour {
    
	// The target we are following
	public Transform target;
	// The distance in the x-z plane to the target
	public float distance = 4.5f;
	// the height we want the camera to be above the target
	public float height = 2.0f;
	// How much we 
	public float heightDamping = 2.0f;

	// Place the script in the Camera-Control group in the component menu
	[AddComponentMenu("Camera-Control/Smooth Follow")]

	void LateUpdate () {
		// Early out if we don't have a target
		if (!target) return;

		float wantedHeight = target.position.y + height;
		float currentHeight = transform.position.y;
	
		// Damp the height
		currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
	
		// Set the position of the camera on the x-z plane to:
		// distance meters behind the target
		transform.position = target.position;
		transform.position -= Vector3.forward * distance;

		// Set the height of the camera
		transform.position = new Vector3(0,currentHeight,transform.position.z);
	}
}