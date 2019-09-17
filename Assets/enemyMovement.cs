using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Rigidbody2D enemy;

    public float xMax;

    public float xMin;

    public float enemySpeed;

    public float yConstant;
    // Start is called before the first frame update
    void Start()
    {
        yConstant = enemy.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.transform.position.x > xMax)
        {
            enemy.velocity = new Vector2(-enemySpeed, 0f); 
        }
       
       

        else if (enemy.transform.position.x < xMin)
        {

            enemy.velocity = new Vector2(enemySpeed, 0f);
            Debug.Log("Move RIght");
        }

    }
}

