using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{

     Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("chav", 0);
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("chav", 1);
        }
    }
}
