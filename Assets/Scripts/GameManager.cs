using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float toplamPuan;
    float maxScor=100;
    public Slider slider;
    public GameObject star;
    bool skor;
    public Image bronz;
    public Image gumus;
    public Image altin;
 

    private void Start()
    {
        skor = false;
        toplamPuan = 0;
       
    }
    void Update()
    {
        slider.value = toplamPuan;

        if (skor==true)
        {
            Scor(25);
            
            skor = false;
            if (toplamPuan==50)
            {
               bronz.gameObject.SetActive(true);

            }
            else if (toplamPuan==75)
            {
                bronz.gameObject.SetActive(false);
                gumus.gameObject.SetActive(true);
            }
            else if (toplamPuan == 100)
            {
                gumus.gameObject.SetActive (false); 
                altin.gameObject.SetActive(true);
            }
        }
    }
    public void Scor(float puan)
    {
        
        if (toplamPuan<maxScor)
        {
            toplamPuan += puan;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (star.gameObject.tag == "stars") ;
        {
            skor = true;
            Destroy(collision.gameObject);  

        }
    }

}
