using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARVRSwitch : MonoBehaviour
{
    public GameObject ARPassthrough;
    public GameObject VRscape;

    private bool isObjectAActive = true;

    public void ToggleObjects()
    {
        if (isObjectAActive)
        {
            ARPassthrough.SetActive(false);
            VRscape.SetActive(true);
            isObjectAActive = false;
        }
        else
        {
            ARPassthrough.SetActive(true);
            VRscape.SetActive(false);
            isObjectAActive = true;
        }
    }
}