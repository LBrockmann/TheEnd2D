using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public string wordName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 MousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(MousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("you hit something");
                if(hit.collider.CompareTag("Word"))
                {
                     wordName = hit.collider.gameObject.name;
                }
            }
        }
    }
}
