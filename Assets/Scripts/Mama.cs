using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Mama : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _text;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Mama"))

        {
            Destroy(other.gameObject);

            Score.totalScore++;

            _text.text = Score.totalScore.ToString();

            

        }
    }
}
