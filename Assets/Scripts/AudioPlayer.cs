using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Move.dead += PlayAudio;
    }

    private void OnDisable()
    {
        Move.dead -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }
}
