﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueBasico : MonoBehaviour {
    int health = 100;
    public int velocidad;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * velocidad;
    }
}
