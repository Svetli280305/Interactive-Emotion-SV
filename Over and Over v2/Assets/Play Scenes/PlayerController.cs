using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;
    bool isOnGround = true;
    public float checkRadius = 1f;
    public float jumpForce = 300f;
    Animator myAnim;

    public bool isInForeground = true;



    //Ceate a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;
    float movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        //Find the rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            isInForeground = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            isInForeground = true;
        }

        myAnim.SetFloat("speed", Input.GetAxis("Horizontal"));
        //Create a 'float' that will be equal to the players horizontal input
        //float movementValueX = Input.GetAxis("Horizontal") * movementSpeed;
        float movementValueX = Input.GetAxis("Horizontal");

        playerObject.velocity = new Vector2(movementValueX * movementSpeed, playerObject.velocity.y);

        //Change the X velocity of the Rigidbody2D to be equal to the movement value
        //playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.1f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    public void Jump()
    {
        if (isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
            myAnim.SetTrigger("Jump");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.transform.position, 0.1f);
    }

}

