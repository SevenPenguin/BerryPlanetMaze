using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 myVector = new Vector2(10, 20);
        //int wholeNumber;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bool playerFront = (vertical < 0 && horizontal == 0);
        anim.SetBool("playerFront", playerFront);

        bool playerBack = (vertical > 0 && horizontal == 0);
        anim.SetBool("playerBack", playerBack);

        bool playerLeft = (horizontal < 0 && vertical == 0);
        anim.SetBool("playerLeft", playerLeft);

        bool playerRight = (horizontal > 0 && vertical == 0);
        anim.SetBool("playerRight", playerRight);

        //Debug.Log(direction);

        //store positionn of ryan in a variable
        Vector2 position = transform.position;

        //update the x position of the variable
        position.x = position.x + (0.05f * horizontal);
        position.y = position.y + (0.05f * vertical);

        //if (position.x < 10) stay in the camera {}

        //update the gameObject position
        
        transform.position = position;
        
    }
}
