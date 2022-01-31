using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    bool active = false;

    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    void Update()
    {
        if (active == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                TriggerDialogue();

            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Is in trigger");
        if (other.gameObject.tag == "Player")
        {

            active = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Is in trigger");
        if (other.gameObject.tag == "Player")
        {

            active = false;
            FindObjectOfType<DialogueManager>().EndDialogue();
        }
    }
}
