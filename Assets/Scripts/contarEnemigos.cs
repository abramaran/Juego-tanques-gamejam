using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class contarEnemigos : MonoBehaviour {
    public int cuenta = 0;
    public Text textoContador;

	void Update () {
        if (cuenta >= 6) {
            SceneManager.LoadScene("menugirando");
        }
        textoContador.text = "Enemigos: " + cuenta + "/6";
	}
}
