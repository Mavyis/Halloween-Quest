using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int playerDamage = 20;

    public void OnTriggerEnter(Collider colisao)
    {
        //dano que dou
        if (colisao.gameObject.tag == "inimigo")
        {
            Debug.Log("Colidiu com a arma");
            colisao.gameObject.GetComponent<EnemyStats>().TakeDamage(playerDamage);
            StartCoroutine(Die());
        }

    }
    void Update()
    {
        Destroy(gameObject, 1);
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(0);
        Destroy(gameObject, 0);
    }
}