using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Mama : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TextMeshProUGUI _text2;

    [SerializeField] GameObject _star1;
    [SerializeField] GameObject _star2;
    [SerializeField] GameObject _star3;
    [SerializeField] GameObject _kurdele1;
    [SerializeField] GameObject _kurdele2;
    [SerializeField] GameObject _kurdele3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Mama"))

        {
            Destroy(other.gameObject);

            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>().MamaAudio();

            Score.totalScore+=10;
            Score.mamaScore+=1;

            _text.text = "Score: " + Score.totalScore.ToString();
            _text2.text = "x " + Score.mamaScore.ToString();
        }

        if(Score.mamaScore > 9) {
            _star1.SetActive(true);
            _star2.SetActive(true);
            _star3.SetActive(true);

            _kurdele1.SetActive(true);
            _kurdele2.SetActive(false);
            _kurdele3.SetActive(false);
        } else if(Score.mamaScore >= 5) {
            _star1.SetActive(true);
            _star2.SetActive(true);
            _star3.SetActive(false);

            _kurdele1.SetActive(false);
            _kurdele2.SetActive(true);
            _kurdele3.SetActive(false);
        } else if(Score.mamaScore >= 1) {
            _star1.SetActive(true);
            _star2.SetActive(false);
            _star3.SetActive(false);

            _kurdele1.SetActive(false);
            _kurdele2.SetActive(false);
            _kurdele3.SetActive(true);
        }
    }
}
