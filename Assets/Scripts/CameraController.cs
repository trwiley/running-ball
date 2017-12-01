using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject PlayerRef;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {

        //Have offset equal the camera's position minus the player object's position.
        offset = transform.position - PlayerRef.transform.position;
    }

    // Runs after all items in update have been processed.
    void LateUpdate()
    {
        //Adjust the camera position using the offset in relation to the player.
        transform.position = PlayerRef.transform.position + offset;
    }
}

