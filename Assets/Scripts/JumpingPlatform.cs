using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlatform : MoveScenario 
{
	
	private float jumpForce = 10;
	public AudioClip springSound;
	private AudioSource myAudio;

	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource> ();

	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			myAudio.clip = springSound;
			myAudio.Play ();
			coll.rigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
		}
	}
}
