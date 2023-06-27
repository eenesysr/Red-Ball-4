using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject panel;
    public GameObject SesAc;
    public AudioSource asc;
    bool ses = false;

    private void Start()
    {
        
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        panel.gameObject.SetActive(true);
        
    }
    public void Devam()
    {
        panel.gameObject.SetActive(false);
        Time.timeScale = 1f;    
    }
    public void againGame()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;    
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void SesKapatAc()
    {
        if (ses == false)
        {
            asc.Pause();
            ses = true;
            SesAc.SetActive(false);
        }
        else
        {
            asc.Play(); 
            ses = false;
            SesAc.SetActive(true);
        }
    }
 
    
}
