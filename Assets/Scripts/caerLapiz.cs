using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caerLapiz : MonoBehaviour {
    public Camera camara;
    public float tiempoEnLlegar = 1.5f;
    Vector3 posInic;


    private void Start() {
        posInic = camara.transform.position - new Vector3(0, 2, 0);
    }

    public void caer(Vector3 destino) {
        StartCoroutine(moverse(destino));
    }

    IEnumerator moverse(Vector3 destino) {
        float elapsedTime = 0;

        while (elapsedTime < tiempoEnLlegar) {
            transform.position = Vector3.Lerp(posInic, destino, (elapsedTime / tiempoEnLlegar));
            elapsedTime += Time.deltaTime;
            transform.LookAt(destino);
            yield return null;
        }
        transform.position = new Vector3(100, 100, 90);
        yield return null;
    }
}
