using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Falar : MonoBehaviour
{

    public DialogMFalar dialogMFalar;
    public List<string> npcConvo = new List<string>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          dialogMFalar.Start_Dialog( npcConvo);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogMFalar.StopDialog();
        }
    }


    private void OnDestroy()
    {
        dialogMFalar.StopDialog();

    }
}
