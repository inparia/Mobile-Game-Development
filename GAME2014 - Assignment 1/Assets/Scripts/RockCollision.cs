using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockCollision : MonoBehaviour
{
    //Creating variables
   
    public GameObject player, lifeOne, lifeTwo, lifeThree;
    public Button button;
    public AudioSource hit;
    public int life;
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
                
                lifeOne.gameObject.SetActive(false);
                player.gameObject.SetActive(false);
                button.gameObject.SetActive(true);
            }
        }
    }
}
