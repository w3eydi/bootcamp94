using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioClip attack = default;

    [SerializeField]
    AudioClip coplate = default;

    [SerializeField]
    AudioClip damage = default;

    [SerializeField]
    AudioClip gameover = default;

    [SerializeField]
    AudioClip jump = default;

    [SerializeField]
    AudioClip mama = default;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void AttackAudio()
    {
        audioSource.PlayOneShot(attack);
    }
    public void ComplateAudio()
    {
        audioSource.PlayOneShot(coplate);
    }
    public void DamageAudio()
    {
        audioSource.PlayOneShot(damage);
    }
    public void GameoverAudio()
    {
        audioSource.PlayOneShot(gameover);
    }
    public void JumpAudio()
    {
        audioSource.PlayOneShot(jump);
    }
    public void MamaAudio()
    {
        audioSource.PlayOneShot(mama);
    }
}
