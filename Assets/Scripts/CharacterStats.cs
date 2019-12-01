using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public Slider life;
    public float max_Life = 100f;
    public float cur_Life = 0f;
    public AudioSource Dano;
    public AudioSource Chas;
    public AudioSource Musica;
    public GameObject MyPrefab;
    public GameObject Icon ;
    public float shootForce = 0.5f;
    public Transform spawn;
    public GameObject carta;
    public GameObject chave;

    public Text Docinhos;
    private int docesam;
    public int value = 1;

    void Start()
    {
        cur_Life = max_Life;
        life.value = cur_Life;
        docesam = 0; 
        carta.SetActive(true);
        Time.timeScale = 0;
        chave.SetActive(false);
        Instantiate(life, transform.position, transform.rotation);
        Musica.Play();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(MyPrefab, transform.position, transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
        }

        if (Input.GetKey(KeyCode.U))
        {
            carta.SetActive(false);
            Time.timeScale = 1;
        }

        Docinhos.text = "" + docesam;
    }

    void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.tag == "inimigo")
        {
            docesam += value;
        }
        if(colisao.gameObject.tag =="Chave")
        {
            chave.SetActive(true);
            Chas.Play();
        }
        if (colisao.gameObject.tag == "Portao")
        {
            chave.SetActive(false);
            Chas.Play();
        }
        if (colisao.gameObject.tag == "Finish")
        {
            Musica.Stop();
        }
    }

    public void TakeDamage(float amount)
    {
        cur_Life -= amount;
        life.value = cur_Life;
        Dano.Play();
        if (cur_Life <= 0)
        {
            StartCoroutine(Respawn());
        }

    }

    public void SetDefaults()
    {
        cur_Life = max_Life;
        life.value = cur_Life;
    }

    public  void Cura(float amount)
    {
        cur_Life += amount;
        life.value = cur_Life;
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(1);
        gameObject.transform.position = spawn.position;
        SetDefaults();
        chave.SetActive(false);
        docesam = 0;
        Debug.Log("Respawno");
    }



}
