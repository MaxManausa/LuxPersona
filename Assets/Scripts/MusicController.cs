using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToCheck;
    [SerializeField] private AudioSource audioSource;

    public bool musicPlaying = true;
    
    void CheckObjects()
    {
        foreach (GameObject obj in objectsToCheck)
        {
            if (obj.activeSelf)
            {
                if (musicPlaying)
                {
                    audioSource.Stop();
                    musicPlaying = false;
                }
                return;
            }
        }

        if (!musicPlaying)
        {
            audioSource.Play();
            musicPlaying = true;
        }
    }
}
