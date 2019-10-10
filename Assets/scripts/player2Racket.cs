﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Racket : MonoBehaviour
{
    [SerializeField]
    private float speedMouvement = 200f;

     
    
    void FixedUpdate()
    {
        float moveVerttical = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveVerttical) * speedMouvement;
    }
}
