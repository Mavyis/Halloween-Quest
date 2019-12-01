using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lixoanim : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("Abre", 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     void OnTriggerEnter(Collider coli)
    {
        if (coli.gameObject.tag == "Player")
        {
                anim.SetInteger("Abre", 1);
        }
    }

     void OnTriggerExit(Collider other)
    {
        anim.SetInteger("Abre", 0);
    }
}
