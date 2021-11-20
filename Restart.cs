using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
    public Button RestartButton;
    public TextMeshProUGUI GameOverText;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        RestartButton.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);

    }
}
