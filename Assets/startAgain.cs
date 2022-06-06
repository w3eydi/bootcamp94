using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startAgain : MonoBehaviour
{

    
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject pauseButton;

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f; 
        pauseButton.SetActive(true);
        Score.totalScore = 0;
        Score.mamaScore = 0;
        Score.mamaScore = 0;
    }
}
