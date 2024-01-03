using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip walkSound;
    public AudioClip jumpSound;
    public AudioClip chakjeeSound;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void PlayWalk()
    {
        audio.clip = walkSound;
        audio.Play();
    }
    void PlayJumpSound()
    {
        audio.clip = jumpSound;
        audio.Play();
    }
    void PlayChakjeeSound()
    {
        audio.clip = chakjeeSound;
        audio.Play();
    }
}
