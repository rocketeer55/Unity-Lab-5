﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
    
    public float speed;
    private Rigidbody2D rb2d;
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(speed, 0);
    }
    void Update()
    {
        
    }
}
