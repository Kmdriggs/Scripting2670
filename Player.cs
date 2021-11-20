using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
   // public float horizontalInput;
   // public float speed = 50.0f;
  //  public float xRange = 60.0f;
    public float bulletDelay = 1f;
   

    public GameObject bullet;
    public GameObject restartButton;
    public TextMeshProUGUI GameOverText;

    void Update()
    {
       // if (transform.position.x < -xRange)
      //  {
       //     transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       // }

       // if (transform.position.x > xRange)
       // {
        //     transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       // }

      //  horizontalInput = Input.GetAxis("Horizontal");
      //  transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        //Launch Bullet
       // if (Input.GetKeyDown(KeyCode.Mouse0))
      //  {
      //      Instantiate(bullet, transform.position, bullet.transform.rotation);
      //  }

   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            restartButton.SetActive(true);
            GameOverText.gameObject.SetActive(true);
        }
    }
}
}
