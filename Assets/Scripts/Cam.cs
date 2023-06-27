using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform target;
    
    // Update is called once per frame
   
  
    void Update()
    {
        Vector3 vec = transform.position;
        if (target.transform.position.x>0f && target.transform.position.x<37.5f)
        {
            transform.position = new Vector3(target.transform.position.x, 0, -10);
        }
  //      vec.x = Mathf.Lerp(transform.position.x, target.transform.position.x, 0.3f);

    }

}
