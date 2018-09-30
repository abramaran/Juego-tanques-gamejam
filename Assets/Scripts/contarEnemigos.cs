using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contarEnemigos : MonoBehaviour {
    public int cuenta = 0;

	void Update () {
        if (cuenta >= 10) {
            SceneManager.LoadScene("menugirando");
        }
	}
}
