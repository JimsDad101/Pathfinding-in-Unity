﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

     void OnCollisionEnter (Collision col) 
        {
          if (col.gameObject.CompareTag("Pacman"))
            {
              Destroy(gameObject);
            }
        }
}

