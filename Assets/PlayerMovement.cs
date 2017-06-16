using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float movementForce = 10;
	public float rotation = 100;

	void Update () {
		if(Input.GetKey("w")) {
			transform.Translate(Vector3.up * -movementForce * Time.deltaTime, Space.Self);
		}

		if(Input.GetKey("a")) {
			transform.Rotate(Vector3.forward * -rotation * Time.deltaTime);
		}

		if(Input.GetKey("d")) {
			transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
		}

	}
}
