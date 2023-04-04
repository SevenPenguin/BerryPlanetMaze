using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
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
