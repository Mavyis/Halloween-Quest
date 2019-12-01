using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public float damage = 20f;
    public float life = 50f;
    float cur_lifeE = 0f;
    Animator anim;
    public GameObject Morte;
    public AudioSource Hitado;

    void Start()
    {
        cur_lifeE = life;
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            colisao.gameObject.GetComponent<CharacterStats>().TakeDamage(damage);
            anim.SetInteger("Agora", 1);
        }

    }
    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.tag == "Player")
        {
            anim.SetInteger("Agora", 0);
        }

    }

    public void TakeDamage(float amount)
    {
        cur_lifeE -= amount;
        if(cur_lifeE <= 0)
        { 
            anim.SetInteger("Agora", 2);
            StartCoroutine(Die());
            Instantiate(Morte, transform.position, transform.rotation);
            Hitado.Play();
        }

    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject, 0);
    }

}
