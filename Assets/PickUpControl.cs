﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            //other.GetComponent<UFOContoller>().IncreaseSpeed();


            //Play Sounds
            //Add to player score or powerup 
            Destroy(gameObject);
        }
    }
}

