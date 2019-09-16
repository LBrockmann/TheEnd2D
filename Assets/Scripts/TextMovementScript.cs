using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        if (isSansSerrif)
        {
            if (isNormal)
            {
                rend.sprite = normal;
                //normalHitbox.GetComponent<PolygonCollider2D>().sharedMaterial = normalMaterial;
                //proporties
                isNormal = false;
            }

            if (isItalics && isBold == false)
            {
                rend.sprite = italics;

            }

            if (isBold && isItalics == false)
            {
                rend.sprite = bold;
                //boldHitbox.GetComponent<PolygonCollider2D>().sharedMaterial = boldMaterial;

            }

            if (isItalics && isBold)
            {
                rend.sprite = italicBold;

            }
        }

        if (isSerrif)
        {
            
            //Set hitbox here
            if (isNormal)
            {
                rend.sprite = normalS;
                GetComponent<PolygonCollider2D>().sharedMaterial = normalMaterial;
                //proporties
                isNormal = false;
            }

            if (isItalics && isBold == false)
            {
                rend.sprite = italics;

            }

            if (isBold && isItalics == false)
            {
                rend.sprite = bold;
                GetComponent<PolygonCollider2D>().sharedMaterial = boldMaterial;

            }

            if (isItalics && isBold)
            {
                rend.sprite = italicBold;

            } 
        }




    }

   

    private void OnTriggerStay2D(Collider2D other)
    {
         
    }
}
