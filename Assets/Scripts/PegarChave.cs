using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarChave : MonoBehaviour
{

    public Component doorcolliderhere;

    void Start()
    {  
        
    }

 
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.W))
        {
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
            gameObject.SetActive(false);
        }       
    }

    IEnumerator Apa()
    {
        yield return new WaitForSeconds(15);
        gameObject.SetActive(true);
    }
}
