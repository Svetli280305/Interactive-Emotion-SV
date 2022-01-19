using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public bool talks;  //If true then the object can talk to the player
   
    public GameObject itemNeeded; //item needed in order to interact with this item
    public string message; //the message this object will give the player
    
    public void DoInteraction()
    {
        //Picked up and put in inventory
        gameObject.SetActive(false);
    }
    
    public void Talk()
    {
        Debug.Log(message);
    }
}
