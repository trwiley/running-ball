/***************************************************************************
 * Name: PlayerController
 * Class: CSCI-C 490
 * Project: Final
 * Purpose: Control the player movement. (Based off of the roll-a-ball game)
 ***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb; //Access to player RigidBody

    public float speed = 1; //How fast the ball moves

    public GameObject gm;
   
    /********************************************************************
    * Name: Start
    * Purpose: Initialize the scene.
    ********************************************************************/
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    /****************************************************************
    * Name: FixedUpdate
    * Purpose: Update at every frame.
    **************************************************************/
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

         //Control direction and speed of player

        if(Input.GetKeyUp(KeyCode.Space))
        {
            movement = new Vector3(moveHorizontal, 6.0f, moveVertical);
        }
        rb.AddForce(movement * (speed / 2));
    }

    /***********************************************************************
    * Name: OnCollisionEnter
    * Arguments: collision object.
    * Purpose: Control collisions between the player and various elements 
    * of the game.
    **********************************************************************/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            AudioSource collideAudio = collision.collider.gameObject.GetComponent<AudioSource>();
            collideAudio.Play();
            Vector3 pushBack = new Vector3(0, 0, -10.0f);
            rb.AddForce(pushBack * speed);
            
        }

        //Disable the powerup when colliding with it and make the ball speed up.
        if (collision.collider.tag == "PowerUp")
        {
            AudioSource collideAudio = collision.collider.gameObject.GetComponent<AudioSource>();
            collideAudio.Play();
            collision.collider.gameObject.SetActive(false);
            speed++;
        }

        //Restart the level if the player falls off of the platform.
        if (collision.collider.tag == "KillField")
        {
            gm.GetComponent<GameMaster>().ReloadCurrentLevel();
        }

        // Move to the next level if the current level is not the last level.
        // If the current level if the last one, load the win screen.
        if (collision.collider.tag == "Finish")
        {
            if(gm.GetComponent<GameMaster>().level < 5)
            {
                gm.GetComponent<GameMaster>().LoadNextLevel();
            }

            if(gm.GetComponent<GameMaster>().level == 5)
            {
                gm.GetComponent<GameMaster>().ShowWinScreen();
            }
        }
    }

}

