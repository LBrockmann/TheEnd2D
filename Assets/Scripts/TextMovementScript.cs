﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMovementScript : MonoBehaviour
{
    public Rigidbody2D rigbod;
    public SpriteRenderer rend;
    public PhysicsMaterial2D normalMaterial;
    public PhysicsMaterial2D boldMaterial; 
    
    public Sprite normal;
    public Sprite italics;
    public Sprite bold;
    public Sprite italicBold;

    public bool isNormal;
    public bool isItalics;
    public bool isBold;
    public bool isItalicBold;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNormal)
        {
            rend.sprite = normal;
            GetComponent<BoxCollider2D>().sharedMaterial = normalMaterial;
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
            GetComponent<BoxCollider2D>().sharedMaterial = boldMaterial;

        }

        if (isItalicBold)
        {
            rend.sprite = italicBold;

        }
        
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
         
    }
}