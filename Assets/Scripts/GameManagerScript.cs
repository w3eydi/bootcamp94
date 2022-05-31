using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Play Pause Button
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject pauseButton;

    public void PauseGame() {
        Time.timeScale = 0f;
        playButton.SetActive(true); // butonu görünür yapar
        pauseButton.SetActive(false); // butonu ekrandan kaldırır
    }
    
    public void PlayGame() {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
        playButton.SetActive(false);
    }
}
