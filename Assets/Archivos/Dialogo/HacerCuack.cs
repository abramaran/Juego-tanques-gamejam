using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerCuack : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play(); //cada vez que hagas click izquierdo reproduce esto
        }
	}
}
