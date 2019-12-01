using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveAparece : MonoBehaviour
{
    public GameObject chave;

    void Start()
    {
        chave.SetActive(false);
    }

    void OntriggerEnter()
    {
        chave.SetActive(true);
    }
}
