using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranscriptOnOff : MonoBehaviour

{
    [SerializeField] private GameObject objectToActivate;

    private void Start()
    {
        // Set the initial state of the object
        objectToActivate.SetActive(false);
    }

    public void ToggleObjectActiveState()
    {
        // Invert the current active state of the object
        objectToActivate.SetActive(!objectToActivate.activeSelf);
    }
}
