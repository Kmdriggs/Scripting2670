using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Player : MonoBehaviour
{
  [SerializeField] private GameObject myPlayer;
  public GameObject bullet;
  public GameObject player1;
  public GameObject restartButton;
  public TextMeshProUGUI GameOverText;
  private float topBound = 25;
  private float lowerBound = -70;
  private float speed = 40.0f;

  void Start()
  {
   
  }
  

  public void PointerDown()
  {
    //bullet shoot
     Instantiate(bullet, transform.position, bullet.transform.rotation);
  }

  public void activePlayer()
  {
    myPlayer.SetActive(true);
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Enemy"))
    {
      restartButton.SetActive(true);
      GameOverText.gameObject.SetActive(true);
      Destroy(gameObject);
    }
  }
}
  
