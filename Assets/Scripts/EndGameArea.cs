using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameArea : MonoBehaviour {

	public string next_level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag ("Player")) 
		{
			Debug.Log ("EndGame");
			StartCoroutine (NextSceneDelay ());

		}
	}

	IEnumerator NextSceneDelay()
	{
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene (next_level);
	}
}
