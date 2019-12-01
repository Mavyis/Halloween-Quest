using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falando : MonoBehaviour
{
    public string EntradaTexto;
    char TextoSaida;
    string Menssage = "";
    public bool escrever;
    public string npcName = "";

    void Update()
    {
        if(escrever == true)
        {
            StartCoroutine(MaquinaDeEscrever());
        }
    }

     void OnGUI()
    {
        Rect MyRect = new Rect(250, 400, Screen.width - 500, 100);
        GUILayout.BeginArea(MyRect);
        GUILayout.TextArea(Menssage);
        GUILayout.EndArea();
        GUILayout.Width(0);
    }

    IEnumerator MaquinaDeEscrever()
    {
        escrever = false;
        for(int i =0; i < EntradaTexto.Length; i++)
        {
            TextoSaida = EntradaTexto[i];
            Menssage += TextoSaida;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));
        }
        yield return new WaitForSeconds(0);
        Menssage = "";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            escrever = true;
        }

    }


}
