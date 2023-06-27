using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float JumpPower = 10f;
    float velocity;
    float timediff = 0.2f;
    float timeSize = 0;
    bool zipla = false;
    public GameObject gm;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        velocity = 0;

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (velocity < 0)
            {
                velocity += 1f;
            }
            else
            {
                if (velocity < 6f)
                {
                    if (Time.time > timeSize)
                    {
                        velocity += 1f;
                        timeSize += timediff;
                    }

                }
                rb.velocity = new Vector2(velocity, rb.velocity.y);
            }



        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (velocity > 0)
            {
                velocity--;

            }
            else
            {
                if (velocity > -6f)
                {
                    if (Time.time > timeSize)
                    {
                        velocity -= 1f;
                        timeSize += timediff;
                    }
                }
                rb.velocity = new Vector2(velocity, rb.velocity.y);
            }

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && zipla == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpPower);  //Yukarý(Zýplama) gidiþ
            zipla = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        zipla = false;



    }

}
