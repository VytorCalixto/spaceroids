using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float movementForce = 1000;
	public float rotation = 100;
	public Rigidbody rb;
	public ParticleSystem leftEngine;
	public ParticleSystem rightEngine;

	void FixedUpdate () {
		if(Input.GetKey("w")) {
			rb.AddForce(transform.up * -movementForce * Time.deltaTime);
			leftEngine.Play();
			rightEngine.Play();
		} else {
			leftEngine.Stop();
			rightEngine.Stop();
		}

		if(Input.GetKey("a")) {
			transform.Rotate(Vector3.forward * -rotation * Time.deltaTime);
		}

		if(Input.GetKey("d")) {
			transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
		}

	}
}
