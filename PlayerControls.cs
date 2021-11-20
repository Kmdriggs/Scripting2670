using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private GameObject Player;
 
   private bool moveLeft;
   private bool moveRight;
   private float horizontalMove;
   private float speed = 3;
   private float horizontalInput;
   private float xRange = 60.0f;

   void start()
    {
        moveLeft = false;
        moveRight = false;
    }
  
  public void leftButton()
  {
      moveLeft = true;
      moveRight = false;
  }

  public void rightButton()
  {
      moveLeft = false;
      moveRight = true;
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
