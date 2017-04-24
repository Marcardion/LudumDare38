using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScenario : MonoBehaviour {

	float axisHorizontal;
	float axisVertical;	

	void Update () {
		UpdateRotation ();
	}

	void UpdateRotation ()
	{
		InterpolateAxis ();

		transform.rotation = Quaternion.Euler (new Vector3 (45f * axisVertical, 0, -45f * axisHorizontal));
	}

	void InterpolateAxis()
	{
		axisHorizontal = Mathf.Lerp (axisHorizontal, Input.GetAxis ("Horizontal"), 7 * Time.deltaTime);
		axisVertical = Mathf.Lerp (axisVertical, Input.GetAxis ("Vertical"), 7 * Time.deltaTime);
	}
}
