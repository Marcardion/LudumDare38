using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	public GameObject player;       //Public variable to store a reference to the player game object
	public float offsetY;
	public float offsetZ;

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offsetY, player.transform.position.z - offsetZ);
	}
}
