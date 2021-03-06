﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RockCollision : MonoBehaviour
{
    //Creating objects
   
    public GameObject player, lifeOne, lifeTwo, lifeThree, key;
    public AudioSource hit;
    public int life;
    public GameObject rockPanel, endPanel, winPanel;
    // Start is called before the first frame update
    void Start()
    {
        //Initializing Life to 3, and display lives on screen
        life = 3;
        lifeOne.gameObject.SetActive(true);
        lifeTwo.gameObject.SetActive(true);
        lifeThree.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Check Rock Collision
        if (col.gameObject.tag.Equals("Rock"))
        {

            //Disable the rock
            col.gameObject.SetActive(false);
            //Play hit sound
            hit.Play();
            //Decrement Life by 1 everytime player hits the rock
            life--;

            //Disable player's life sprite each time player loses life.
            if(life == 2)
            {
                lifeThree.gameObject.SetActive(false);
            }
            if (life == 1)
            {
                lifeTwo.gameObject.SetActive(false);
            }
            //If life reaches 0, game over.
            if (life == 0)
            {
                endPanel.gameObject.SetActive(true);
                lifeOne.gameObject.SetActive(false);
                player.gameObject.SetActive(false);
                rockPanel.gameObject.SetActive(false);
                key.SetActive(false);
            }


        }

        //Check Key Collision
        if (col.gameObject.tag.Equals("Win"))
        {
            player.gameObject.SetActive(false);
            rockPanel.gameObject.SetActive(false);
            winPanel.SetActive(true);
            key.SetActive(false);
        }
    }
}
