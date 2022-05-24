using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Mama : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _text2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Mama"))

        {
            Destroy(other.gameObject);

            Score.totalScore+=10;
            Score.mamaScore+=1;

            _text.text = "Score: " + Score.totalScore.ToString();
            _text2.text = "x " + Score.mamaScore.ToString();

            

        }
    }
}
