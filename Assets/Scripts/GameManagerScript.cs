using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // Play Pause Button <<<<<<<<<<<<<<<<<<<<<<<<<<
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

    // Try Again Menu <<<<<<<<<<<<<<<<<<<<<<<<<<<<
    [SerializeField] GameObject heart;

    public void TryAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Aynı leveli yükler
        Time.timeScale = 1.0f; // Zamanı normale çevirir
        heart.SetActive(true);
        pauseButton.SetActive(true);
        Score.totalScore = 0;
    }

    public void NextLevel() {
        if(SceneManager.GetActiveScene().name == "Level1"){
            SceneManager.LoadScene("Level2");
            Time.timeScale = 1f;
            Score.totalScore = 0;
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().ComplateAudio();
        } else if (SceneManager.GetActiveScene().name == "Level2"){
            SceneManager.LoadScene("BossLevel");
            Time.timeScale = 1f;
            Score.totalScore = 0;
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().ComplateAudio();
        }
    }

}
