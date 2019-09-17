using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canMoveButton : MonoBehaviour
{
    public GameObject player;

    public Transform startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
       if( player.GetComponent<PlayerMovement>().canMove == true)
       {
           player.GetComponent<PlayerMovement>().canMove = false;
           
       }
       else if (player.GetComponent<PlayerMovement>().canMove == false)
       {
           player.GetComponent<PlayerMovement>().canMove = true;
       }
       
       player.transform.position = new Vector3(startPoint.position.x,startPoint.position.y,0f);
    }
}
