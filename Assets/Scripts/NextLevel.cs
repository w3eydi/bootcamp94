using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Jump to Next Level
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Character" && 
        SceneManager.GetActiveScene().name == "Level1"){
            SceneManager.LoadScene("Level2");
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().ComplateAudio();
        } else if (other.gameObject.name == "Character" && 
        SceneManager.GetActiveScene().name == "Level2"){
            SceneManager.LoadScene("BossLevel");
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().ComplateAudio();
        }
    }
}
