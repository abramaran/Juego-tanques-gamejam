using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour {

	public GameObject punto;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(punto.transform.position, Vector3.up, 20 * Time.deltaTime);
	}
}
