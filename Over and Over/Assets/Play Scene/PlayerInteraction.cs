using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
   public GameObject currentInterObj = null;
   public NonPlayerCharacter currentInterObjScript = null;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.F) && currentInterObj)
        {
            Debug.Log("F is pressed");
             //Check to see if this object talks and has a message
            if (currentInterObjScript.talks)
            {
                //Tell the object to give its message
                currentInterObjScript.Talk();
                Debug.Log("talks");
            }
        }
    }
}
