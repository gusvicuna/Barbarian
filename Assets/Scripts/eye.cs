﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye : MonoBehaviour
{
    static public float speed = 5;

    Vector2 velocity;
    Vector2 start;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition() {
        if (transform.position.y > start.y + 3 || transform.position.y < start.y - 3) {
            speed *= -1;
        }
        Vector2 input = new Vector2(0, 1);
        Vector2 direction = input.normalized;
        velocity = direction * speed;
        Vector2 moveAmount = velocity * Time.deltaTime;

        transform.Translate(moveAmount);
    }
}
