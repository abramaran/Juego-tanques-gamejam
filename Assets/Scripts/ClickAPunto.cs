using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAPunto : MonoBehaviour {
    public GameObject cilindro;
    Camera camara;
    Vector3 ajuste = new Vector3(32, 20, 0);
    Vector3 offset = new Vector3(16, 10, 0);
    Vector3 vectViewport;
    Vector3 puntoEnMapa;
    bool semaforoMisil = true;

    // Use this for initialization
    void Start () {
        camara = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (semaforoMisil && Input.GetMouseButtonDown(0)) {
            StartCoroutine("LanzaMisil");
        }
	}

    IEnumerator LanzaMisil() {
        semaforoMisil = false;
        vectViewport = camara.ScreenToViewportPoint(Input.mousePosition);
        puntoEnMapa = Vector3.Scale(vectViewport, ajuste) - offset;
        float auxY = puntoEnMapa.y;
        puntoEnMapa.y = puntoEnMapa.z;
        puntoEnMapa.z = auxY;
        puntoEnMapa *= -1;  //Porque por algún motivo salia invertido
        yield return new WaitForSeconds(1.5f);
        cilindro.transform.position = puntoEnMapa;
        print(puntoEnMapa);
        yield return null;
        cilindro.transform.position = new Vector3(100, 100, 100);
        semaforoMisil = true;
        yield return null;
    }
}
