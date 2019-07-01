using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D body;
    public float walkingSpeed;
    public float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        { // x-axis movement
            body.velocity += jumpSpeed * Vector2.up;
        }

        { // x-axis movement
            var v = body.velocity;
            var speed = 0f;
            var flipLeft = 0;
            
            
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    speed += -walkingSpeed;
                    flipLeft = 1;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    speed += walkingSpeed;
                    flipLeft = 0;
                }
            

            if (flipLeft == 1)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            v.x = speed;
            
            body.velocity = v;
        }

    }
}
