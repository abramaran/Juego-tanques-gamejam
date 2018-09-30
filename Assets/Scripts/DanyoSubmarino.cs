﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DanyoSubmarino : MonoBehaviour {

    public int vida = 100;
    public ParticleSystem humo;
    public GameObject siguiente;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Misil") {
            Vector3 impacto;
            float diametro = other.gameObject.transform.lossyScale.x * 100;

            print("ouch!");

            impacto = other.gameObject.transform.position;
            float resta = Vector3.Distance(transform.position, impacto) * 100;
            print("impacto: " + impacto + ", diametro: " + diametro + ", posicion: " + transform.position + "resta: " + resta);
            print("escala: " + diametro);

            if (resta > diametro / 2) {
                print("fuera del radio");
            } else {
                vida -= (int)(diametro / 2 - resta);
                print("vida: " + vida);
                humo.Play();
            }

            if (vida <= 0) {
                if (siguiente == null) SceneManager.LoadScene("Menugirando");
                siguiente.SetActive(true);
                Destroy(this.gameObject);
            }
        }
    }
}