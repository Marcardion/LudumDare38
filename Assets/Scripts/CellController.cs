using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CellController : MonoBehaviour {

	public AudioClip deathClip;
	private float minHeight = -100;
	private AudioSource myAudio;
	private Animator myAnimator;

	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource> ();
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("r"))
		{
			Death ();
		}

		CheckAltitude ();
	}

	void CheckAltitude()
	{
		if (transform.position.y <= minHeight) 
		{
			Death ();
		}
	}

	public void Death()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	IEnumerator DeathDelay()
	{
		myAnimator.SetBool ("Death", true);
		yield return new WaitForSeconds (1.0f);
		Death ();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.collider.CompareTag ("Enemy")) 
		{
			myAudio.clip = deathClip;
			myAudio.Play ();
			StartCoroutine (DeathDelay ());
		}
	}
}
