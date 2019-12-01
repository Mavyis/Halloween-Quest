using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimaçoes : MonoBehaviour
{
    Animator anim;
    public AudioSource Falando;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("trig", 0);
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetInteger("trig", 1);
        Falando.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetInteger("trig", 0);
        Falando.Stop();
    }
}
