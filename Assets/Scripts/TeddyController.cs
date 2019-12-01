using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyController : MonoBehaviour
{
 
    Vector3 moveDir = Vector3.zero;
    
    Animator anim;
    public AudioSource Hit;


    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Moving
        if (Input.GetKey(KeyCode.W))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition", 1);
            }
            

        }


        //
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("running", false);
            anim.SetInteger("Condition", 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition", 1);
            }


        }


        //
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("running", false);
            anim.SetInteger("Condition", 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition", 1);
            }


        }


        //
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("running", false);
            anim.SetInteger("Condition", 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition", 1);
            }


        }


        //
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("running", false);
            anim.SetInteger("Condition", 0);
        }

        ////
        //GetInput
        if (Input.GetMouseButtonDown (0))
        {
           if(anim.GetBool ("running") == true)
            {
                anim.SetBool("running", false);
                anim.SetInteger("Condition", 0);
            }
            if(anim.GetBool("running") == false)
            {
                Attacking();
            }
            Hit.Play();
        }
        ////
        // jumping

        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetInteger("Condition", 3);
           
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("Condition", 0);
        }

    }


    void Attacking()
    {
        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        anim.SetBool("attacking", true);
        anim.SetInteger("Condition", 2);
        yield return new WaitForSeconds(1);
        anim.SetInteger("Condition", 0);
        anim.SetBool("attacking", false);
    }
}
