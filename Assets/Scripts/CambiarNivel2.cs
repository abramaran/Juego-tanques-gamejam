using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel2 : MonoBehaviour {
	void Start () {
        StartCoroutine(cambiarTrasTiempo());
	}

    IEnumerator cambiarTrasTiempo() {
        print("contando...");
        yield return new WaitForSeconds(55);
        SceneManager.LoadScene("Nivel 2");
    }
}
