using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recibirDanyo : MonoBehaviour {

    public int vida = 100;

    void OnTriggerEnter(Collider other) {
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
        }

        if (vida <= 0) Destroy(this.gameObject);
    }
}
