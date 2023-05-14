using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToCheck;
    [SerializeField] private AudioSource audioSource;

    public bool musicPlaying = true;
    public bool allObjectsInactive = true;
    
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
                    allObjectsInactive = false;
                }
                return;
            }
        }

        if (allObjectsInactive && !musicPlaying)
        {
            audioSource.Play();
            musicPlaying = true;
        }
        else if (!allObjectsInactive && musicPlaying)
        {
            audioSource.Stop();
            musicPlaying = false;
        }
    }
}
