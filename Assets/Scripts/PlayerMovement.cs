﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigbod;

    public float speed;
    public float maxVelocity;
    public float jumpforce;


    public bool canMove;
    public GameObject wordHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            rigbod.velocity = Vector3.ClampMagnitude(rigbod.velocity, maxVelocity);

            if (Input.GetKey(KeyCode.D))
            {
                //rigbod.velocity = new Vector2(speed, rigbod.velocity.y);
                rigbod.AddForce(new Vector2(speed, 0f));
            }

            if (Input.GetKey(KeyCode.A))
            {
                //rigbod.velocity = new Vector2(-speed, rigbod.velocity.y);
                rigbod.AddForce(new Vector2(-speed, 0f));
            }

            /*else
            {
                rigbod.velocity = new Vector2(0f, rigbod.velocity.y);
            }*/

            if (Input.GetKeyDown(KeyCode.W))
            {
                rigbod.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
                Debug.Log("Jump");
            }

        }

    }

    private void OnCollisionStay2D(Collision2D other)
    {
       // other.Collision.gameObject = wordHit;

    }
}
