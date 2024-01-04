using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeSingleton(SingletonFlags.NoAutoInstance)]
public class SoundManager : MonoSingleton<SoundManager>
{
    public AudioClip walkSound;
    public AudioClip jumpSound;
    public AudioClip chakjeeSound;
    public AudioClip dashSound;
    public AudioClip shootSound;
    public AudioClip hitSound;
    public AudioClip bigBumpSound;
    public AudioClip triggerSound;

    private AudioSource[] audios;

    private bool iswalking = false;
    private void Start()
    {
        audios = GetComponentsInChildren<AudioSource>();
    }

    public void PlayWalk()
    {
        audios[1].clip = walkSound;
        if (!iswalking)
        {
            audios[1].Play();
        }

        iswalking = true;
    }
    public void StopWalk()
    {
        audios[1].clip = walkSound;
        audios[1].Stop();
        iswalking = false;
    }
    public void PlayDash()
    {
        audios[0].clip = dashSound;
        audios[0].Play();
    }
    public void PlayJumpSound()
    {
        audios[0].clip = jumpSound;
        audios[0].Play();
    }
    public void PlayChakjeeSound()
    {
        audios[0].clip = chakjeeSound;
        audios[0].Play();
    }
    public void PlayShootSound()
    {
        audios[2].clip = shootSound;
        audios[2].Play();
    }
    public void PlayHitSound()
    {
        audios[0].clip = hitSound;
        audios[0].Play();
    }
    public void PlayBigBumpSound()
    {
        audios[0].clip = bigBumpSound;
        audios[0].Play();
    }
    public void PlayTriggerSound()
    {
        audios[0].clip = triggerSound;
        audios[0].Play();
    }
}
