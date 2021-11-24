using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
   private bool moveLeft;
   private bool moveRight;
   private float horizontalMove;
   private float speed = 3;
   private float horizontalInput;
   private float xRange = 60.0f;
   public GameObject particleSystemObject;
   CharacterController controller;

   void start()
    {
        controller = GetComponent<CharacterController>();
        controller.center = new Vector3(0,1, 0);
        moveLeft = false;
        moveRight = false;
    }
  
  public void leftButton()
  {
      moveLeft = true;
  
  }

  public void rightButton()
  {
      moveLeft = false;
      moveRight = true;
  }

  public void pointerUp()
  {
      moveLeft = false;
      moveRight = false;
  }

   void Update()
   {
       MovementPlayer();

       if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
         transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
   }

    //lets player move
   private void MovementPlayer()
   {
       FixedUpdate();

       //if press left button
       if (moveLeft)
       {
           horizontalMove = -speed;
       }
       ///if press right button
       else if (moveRight)
       {
           horizontalMove = speed;
       }
       //if no press buttons
       else 
       {
           horizontalMove = 0;
       }
   }
    
    //add movement force to player
   private void FixedUpdate()
   {
       transform.Translate(Vector3.right * horizontalMove * Time.deltaTime * speed);
   }
}
