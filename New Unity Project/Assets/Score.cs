using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + scoreText;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreText;
    }

     void OnCollisionEnter (Collision col) 
        {
          if (col.gameObject.CompareTag("pellet"))
            {
              scoreText = scoreText=+ 1;
            }
        }
}

