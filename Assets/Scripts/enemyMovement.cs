using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Rigidbody2D enemy;

    public float xMax;

    public float xMin;

    public float enemySpeed;

    public float yConstant;

    public bool moveLeft;

    public bool moveRight;

    public GameObject player;
    public bool mover;
    public Transform startpoint;
    // Start is called before the first frame update
    void Start()
    {
        yConstant = enemy.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(mover){
        
            if (moveRight)
        {
            enemy.velocity = (new Vector2(enemySpeed, 0f));
        }
        else
        {
            enemy.velocity = (new Vector2(-enemySpeed, 0f)); 
        }

        if (transform.position.x >= xMax)
        {
            moveRight = false;
        }

        if (transform.position.x <= xMin)
        {
            moveRight = true;
        }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Respawn");
            player.transform.position = new Vector2(startpoint.position.x, startpoint.position.y);
        }
    }
}

