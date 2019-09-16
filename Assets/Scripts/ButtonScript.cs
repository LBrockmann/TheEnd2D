using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameManagerScript gm;
    public int wordCount; // normal 1, italic 2, bold 3, italicbold 4

    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("GameController").GetComponent<GameManagerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        
        switch (wordCount)
        {
            case 1 :
                gm.wordClicked.GetComponent<TextMovementScript>().isNormal = true;
                gm.wordClicked.GetComponent<TextMovementScript>().isBold = false;
                gm.wordClicked.GetComponent<TextMovementScript>().isItalics = false;
                break;
            
            case 2 :
                gm.wordClicked.GetComponent<TextMovementScript>().isNormal = false;
                gm.wordClicked.GetComponent<TextMovementScript>().isItalics = true;
                break;
            
            case 3 :
                gm.wordClicked.GetComponent<TextMovementScript>().isNormal = false;
                gm.wordClicked.GetComponent<TextMovementScript>().isBold = true;
                break;
            
            case 4:
                gm.wordClicked.GetComponent<TextMovementScript>().isSansSerrif = true;
                gm.wordClicked.GetComponent<TextMovementScript>().isSerrif = false;
                break;
            
            case 5: 
                gm.wordClicked.GetComponent<TextMovementScript>().isSansSerrif = false;
                gm.wordClicked.GetComponent<TextMovementScript>().isSerrif = true;

                break;
            default:
                    break;
                
        }
        
    }
}
