using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class harvest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Started harvest");



	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {
		Destroy(gameObject);
	} 

}


