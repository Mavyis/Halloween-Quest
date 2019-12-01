using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public AudioSource Musica;
    public GameObject com;

    void Start()
    {
        com.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            com.SetActive(false);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Comandos()
    {
        com.SetActive(true);
    }

    public void StopSong()
    {
        Musica.Stop();
  
    }

    public void PlaySong()
    {
        Musica.Play();
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("saiu");
    }
}
