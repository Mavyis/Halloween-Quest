using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    Animator anim;
    public AudioSource final;
    public GameObject cred;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("cabo", 0);
        cred.SetActive(false);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cred.SetActive(true);
            StartCoroutine(FF());
            anim.SetInteger("cabo", 1);
            final.Play();
        }
    }

    IEnumerator FF()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(QUIT());
    }
    IEnumerator QUIT()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
        Debug.Log("saindo");
    }
}
