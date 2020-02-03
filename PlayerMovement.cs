﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float target = 7f;
    public float moveSpeed = 10f;
    public bool isGround = false;
    private Rigidbody2D body;
    private float xInput;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movement();
        jump();
    }


    void movement()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
      //  body.MovePosition(new Vector3(Input.GetAxis("Horizontal"), 0f, 0f));
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump") && isGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
    }



}
