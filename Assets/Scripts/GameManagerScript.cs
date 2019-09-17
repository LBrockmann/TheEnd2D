using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public bool canMove;
    public GameObject wordClicked;
    public string wordName;

    public float xMovement;
    public static bool editMode;
    public float yMovement;
    // Start is called before the first frame update
    void Start()
    {
        editMode = true;
        xMovement = 0.5f;
        yMovement = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (editMode)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("Moveright");
               wordClicked.transform.position = new Vector3(wordClicked.transform.position.x + xMovement, wordClicked.transform.position.y, 0f);
            }
            
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("Moveright");
                wordClicked.transform.position = new Vector3(wordClicked.transform.position.x - xMovement, wordClicked.transform.position.y, 0f);
            }
            
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Moveright");
                wordClicked.transform.position = new Vector3(wordClicked.transform.position.x, wordClicked.transform.position.y + yMovement, 0f);
            }
            
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Moveright");
                wordClicked.transform.position = new Vector3(wordClicked.transform.position.x, wordClicked.transform.position.y - yMovement, 0f);
            }


            
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 MousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(MousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("you hit something");
                if (hit.collider.CompareTag("Word"))
                {
                    wordClicked = hit.collider.gameObject;
                }
            }
        }
        
        
    }
}
