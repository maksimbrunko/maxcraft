using System.Collections;
using UnityEngine;

public class camcon : MonoBehaviour {

	public KeyCode moveForward;
	public KeyCode moveBackward;
	public KeyCode slideRight;
	public KeyCode slideLeft;
	public KeyCode rotateleft;
	public KeyCode rotateright;

	int acceleration = 50;

	// Use this for initialization
	void Start () { }

	// Update is called once per frame
	void Update () { 

		if (Input.GetKeyDown (rotateleft)) {
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, .5f, 0);
		}

	    if (Input.GetKeyUp (rotateleft)) {
				GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKeyDown (rotateright)) {
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, -.5f, 0);

		}

		if (Input.GetKeyUp (rotateright)) {
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKeyDown (moveForward)) {
			GetComponent<Rigidbody> ().AddRelativeForce (0, 0, acceleration);
		}

		if (Input.GetKeyDown (moveBackward)) {
			GetComponent<Rigidbody> ().AddRelativeForce (0, 0, acceleration);
		}

		if (Input.GetKeyDown (slideLeft)) {
			GetComponent<Rigidbody> ().AddRelativeForce (acceleration, 0, 0);
		}

		if (Input.GetKeyDown (slideRight)) {
			GetComponent<Rigidbody> ().AddRelativeForce (-acceleration, 0, 0);
		}

		if (Input.GetKeyUp (slideLeft) || Input.GetKeyUp (slideRight) || Input.GetKeyUp (moveForward) || Input.GetKeyUp (moveBackward)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);		
		}
	}
}