using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class submarino : MonoBehaviour {
    public GameObject modelo;
    public float velocidad;
    public Text textoCoord;
    public GameObject siguiente;

    // Use this for initialization
    void Start () {
        StartCoroutine(presentar());
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * velocidad;
        if (Mathf.Abs(transform.position.x) > 16 || Mathf.Abs(transform.position.z) > 10) {
            StartCoroutine(escapado()); 
        } else {
            textoCoord.text = "Coordenadas: (" + (int)(((transform.position.x - 16) / 2) * -1) + ", " + (int)(((transform.position.z - 10) / 2) * -1) + ")";
        }
    }

    IEnumerator presentar() {
        modelo.SetActive(true);
        yield return new WaitForSeconds(4);
        modelo.SetActive(false);
    }

    IEnumerator escapado() {
        textoCoord.text = "Se ha escapado";
        yield return new WaitForSeconds(2);
        if (siguiente == null) SceneManager.LoadScene("Menugirando");
        siguiente.SetActive(true);
        gameObject.SetActive(false);
        yield return null;
    }
}
