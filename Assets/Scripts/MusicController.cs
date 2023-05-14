using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject videoScreen;
    
    public bool isMuted = false;

    
    public void Update()
    {
        if (videoScreen.activeSelf)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }

    public void Mute()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
