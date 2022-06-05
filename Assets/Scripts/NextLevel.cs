using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameObject EndofScene;
    [SerializeField] Canvas _touchCanvas;
    [SerializeField] TextMeshProUGUI _scoreText;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Character") {
            Time.timeScale = 0f;
            EndofScene.SetActive(true);
            _touchCanvas.enabled = false;
            _scoreText.text = "Your Score : " + Score.totalScore.ToString();
        }
    }

}
