using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Create a public reference to the player - we will assign this using the unity editor
    public GameObject player;
    public float xOffset = 0;
    public float yOffset = 0;
    public float leftmax = 0;
    public float rightmax = 0;

    // Update is called once per frame 
    void Update()
    {
        //Change our position relative to the players position
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x + xOffset, leftmax, rightmax), player.transform.position.y + yOffset, transform.position.z);
    }
}
