
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public Joystick joystick;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {
        //animator.setFloat("Speed", Mathf.Abs(horizontalMove));

        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
        }
        else if ((joystick.Horizontal <= -.2f))
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }


        /*float verticalMove = joystick.Vertical;



        if (verticalMove >= .5f)
        {
            jump = true;
            //animator.SetBool("IsJump", true);
        }

        if (verticalMove <= -.5f)
        {
            crouch = true;

        }else
        {
            crouch = false;
        }
        */

        //if (Input.GetButtonDown("Jump"))
        //{
        //    jump = true;
        //}
/*
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

*/

    }


    public void OnLanding()
    {
        animator.SetBool("IsJump", false);
    }

    void FixedUpdate()
    {
        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}