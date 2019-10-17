﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astronaunt_controller : MonoBehaviour
{
    public float jumpSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2 (rb.velocity.x, jumpSpeed);
        }
    }
}
