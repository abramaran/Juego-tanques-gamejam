using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour {

    public Text nombreTexto;
    public Text dialogoTexto;

    private Queue<string> frases;

	// Use this for initialization
	void Start () {
        frases = new Queue<string>();
		
	}
    public void StartDialogo(Dialogo dialogo)
    {
        Debug.Log("Empezar conversación con " + dialogo.nombre);

        nombreTexto.text = dialogo.nombre;

        frases.Clear();
        foreach (string frase in dialogo.frases)
        {
            frases.Enqueue(frase);
        }
        DisplayNextFrase();
    }
    public void DisplayNextFrase()
    {
        if(frases.Count == 0)
        {
            FinalDialogo();
            return;
        }
        string frase = frases.Dequeue();
        //Debug.Log(frase);
        // dialogoTexto.text = frase;
        StopAllCoroutines();
        StartCoroutine(TypeFrase(frase));
    }

    IEnumerator TypeFrase(string frase)
    {
        dialogoTexto.text = "";
        foreach(char letra in frase.ToCharArray())
        {
            dialogoTexto.text += letra;
            yield return null;
        }
    }
    void FinalDialogo()
    {
        Debug.Log("Final de la conversación");
    }

}
