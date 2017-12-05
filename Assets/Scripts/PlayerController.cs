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
   

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
     
    }


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

    private void OnCollisionEnter(Collision collision)
    { 
        if (collision.collider.tag == "Enemy")
        {
            Vector3 pushBack = new Vector3(0, 0, -10.0f);
            rb.AddForce(pushBack * speed);
        }
        //Increase speed when coming in contact with a power up.
        if (collision.collider.tag == "PowerUp")
        {
            collision.collider.gameObject.SetActive(false);
            speed++;
        }

        if (collision.collider.tag == "KillField")
        {
            gm.GetComponent<GameMaster>().ReloadCurrentLevel();
        }

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

