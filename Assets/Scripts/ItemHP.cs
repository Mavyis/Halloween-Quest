using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHP : MonoBehaviour
{
    public int curinha = 100;
    public AudioSource comendo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {           
            
            Debug.Log("colidiu");           
                colisao.gameObject.GetComponent<CharacterStats>().Cura(curinha);
               StartCoroutine(Die());
            comendo.Play();
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject, 0);

    }
}
