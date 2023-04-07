using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    private AudioSource walkSound;


    // AudioMovement SFX
    [SerializeField] private AudioSource walkSoundEffect;


    // Start is called before the first frame update
    void Start()
    {
        walkSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 myVector = new Vector2(10, 20);
        //int wholeNumber;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            if (!walkSound.isPlaying)
            {
                walkSound.Play();
            }
            
        }

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
        position.x = position.x + (5f * Time.deltaTime * horizontal);
        position.y = position.y + (5f * Time.deltaTime * vertical);

        walkSoundEffect.Play();

        //if (position.x < 10) stay in the camera {}

        //update the gameObject position

        transform.position = position;
        
    }
}
