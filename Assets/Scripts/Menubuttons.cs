using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubuttons : MonoBehaviour
{

   public void Play()
    {
       
        SceneManager.LoadScene("Level");

    }
    public void level1()
    {
        
        SceneManager.LoadScene("Level1");
        
    }
    public  void back()
    {
        SceneManager.LoadScene("Menu");
       
    }
}
