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
    public AudioClip doorSound;
    public AudioClip fallingSound;

    private AudioSource[] audioSources;

    private bool iswalking = false;
    private bool isfalling = false;
    private void Start()
    {
        audioSources = GetComponentsInChildren<AudioSource>();
    }

    public void PlayWalk()
    {
        audioSources[1].clip = walkSound;
        if (!iswalking)
        {
            audioSources[1].Play();
            iswalking = true;
        }

    }
    public void StopWalk()
    {
        audioSources[1].Stop();
        iswalking = false;
    }
    public void PlayFallingSound()
    {
        audioSources[3].clip = fallingSound;
        if (isfalling) return;
        audioSources[3].Play();
        isfalling = true;
    }
    public void StopFallingSound()
    {
        audioSources[3].Stop();
        isfalling = false;
    }
    public void PlayDash()
    {
        audioSources[0].clip = dashSound;
        audioSources[0].Play();
        audioSources[3].Stop();
        audioSources[3].Play();
    }
    public void PlayJumpSound()
    {
        audioSources[0].clip = jumpSound;
        audioSources[0].Play();
    }
    public void PlayChakjeeSound()
    {
        audioSources[0].clip = chakjeeSound;
        audioSources[0].Play();
    }
    public void PlayShootSound()
    {
        audioSources[2].clip = shootSound;
        audioSources[2].Play();
    }
    public void PlayHitSound()
    {
        audioSources[0].clip = hitSound;
        audioSources[0].Play();
    }
    public void PlayBigBumpSound()
    {
        audioSources[0].clip = bigBumpSound;
        audioSources[0].Play();
    }
    public void PlayTriggerSound()
    {
        audioSources[0].clip = triggerSound;
        audioSources[0].Play();
    }
    public void PlayDoorSound()
    {
        audioSources[0].clip = doorSound;
        audioSources[0].Play();
    }
}
