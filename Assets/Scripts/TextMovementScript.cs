using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class TextMovementScript : MonoBehaviour
{
    public Rigidbody2D rigbod;
    public SpriteRenderer rend;
    public PhysicsMaterial2D normalMaterial;
    public PhysicsMaterial2D boldMaterial;

    public GameObject shitBox;
    public GameObject normalHitbox;
    public GameObject italicHitbox;
    public GameObject boldHitbox;
    public GameObject italicBoldHitbox;
    
    public Sprite normal;
    public Sprite italics;
    public Sprite bold;
    public Sprite italicBold;
    public Sprite normalS;
    public Sprite italicsS;
    public Sprite boldS;
    public Sprite italicBoldS;
    
    public bool isSansSerrif;
    public bool isSerrif;
    public bool isNormal;
    public bool isItalics;
    public bool isBold;
    public bool isItalicBold;
    public float currentY;
    public float currentX;

    public float italicSpeed;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        isSansSerrif = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManagerScript.editMode)
        {
            if (isSansSerrif)
            {
                if (isNormal)
                {
                    rend.sprite = normal;
                    GetComponent<BoxCollider2D>().sharedMaterial = normalMaterial;
                    //proporties
                    isNormal = false;
                    Debug.Log("WHY");
                }

                if (isItalics && isBold == false)
                {
                    rend.sprite = italics;

                }

                if (isBold && isItalics == false)
                {
                    rend.sprite = bold;
                    GetComponent<BoxCollider2D>().sharedMaterial = boldMaterial;

                }

                if (isItalics && isBold)
                {
                    rend.sprite = italicBold;

                }
            }

/*
        if (isSerrif)
        {
            
            //Set hitbox here
            if (isNormal)
            {
                rend.sprite = normalS;
                GetComponent<BoxCollider2D>().sharedMaterial = normalMaterial;
                //proporties
                
            }

            if (isItalics && isBold == false)
            {
                rend.sprite = italics;

            }

            if (isBold && isItalics == false)
            {
                rend.sprite = bold;
                GetComponent<BoxCollider2D>().sharedMaterial = boldMaterial;

            }

            if (isItalics && isBold)
            {
                GetComponent<BoxCollider2D>().sharedMaterial = boldMaterial;
                rend.sprite = italicBold;
            } 
            
        }
        */
        }



    }


   private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit word");
            if (isItalics || isItalics && isBold)
            {
                player.AddForce(transform.right * italicSpeed, ForceMode2D.Impulse); 
                Debug.Log("ITalic push");
            }
            
        }
    }
}
