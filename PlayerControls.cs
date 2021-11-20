using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
 
   private bool moveLeft;
   private bool moveRight;
   private float horizontalMove;
   public float speed = 5;
   public float horizontalInput;
   public float xRange = 60.0f;

   void start()
    {
        moveLeft = false;
        moveRight = false;
    }
  
    //Pressing left button
   public void PointerDownLeft()
   {
       moveLeft = true;
   }

    //not pressing left button
   public void PointerUpLeft()
   {
       moveLeft = false;
   }

   public void PointerDownRight()
   {
       moveRight = true;
   }

   public void PointerUpRight()
   {
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

       FixedUpdate();
   }

    //add movement force to player
   private void FixedUpdate()
   {
       transform.Translate(Vector3.right * horizontalMove * Time.deltaTime * speed);
   }
}
