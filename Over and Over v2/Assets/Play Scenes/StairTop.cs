using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTop : MonoBehaviour
{
    PlayerController player;
    BoxCollider2D stairs;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        stairs = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isInForeground)
        {
            stairs.enabled = true;
        }
        else
        {
            stairs.enabled = false;
        }
    }
}
