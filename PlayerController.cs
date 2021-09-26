using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    private Rigidbody playerRb;
    public KeepScore KeepScore;
    public SpawnManager SpawnManager;

    public bool isGameActive;

    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    //player movement
    void playerMovement()
    {
        if(SpawnManager.isGameActive)
        {
            if (Input.GetKey (KeyCode.LeftShift))
            {
                transform.position += transform.TransformDirection (Vector3.left) * Time.deltaTime * movementSpeed;
            }
            else if (Input.GetKey (KeyCode.RightShift))
            {
                transform.position += transform.TransformDirection (Vector3.right) * Time.deltaTime * movementSpeed;
            }
        }
    }

    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            SpawnManager.GameOver();
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            KeepScore.UpdateScore(5);
        }
    }

}
