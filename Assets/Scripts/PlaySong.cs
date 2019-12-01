using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    public AudioSource Corvo;
    public AudioSource Cem;
    public AudioSource Ilha;
    public AudioSource Musica;
    public int n;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 

    }

    void OnTriggerEnter()
    {
        if (n == 0)
        {
            Musica.Play();
        }
        if (n == 1)
        {
            Corvo.Play();
        }
        if (n == 2)
        {
            Cem.Play();
        }
        if (n == 3)
        {
            Ilha.Play();
        }
    }
}
