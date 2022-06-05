using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] GameObject EndofScene;
    [SerializeField] Canvas _touchCanvas;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Character") {
            Time.timeScale = 0f;
            EndofScene.SetActive(true);
            _touchCanvas.enabled = false;
        }
    }

}
