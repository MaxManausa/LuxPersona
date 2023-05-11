using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects; // an array of the game objects to switch between
    private int currentIndex = 0; // the index of the current game object

    private void Start()
    {
        // set the initial game object active
        gameObjects[currentIndex].SetActive(true);

        // set all other game objects inactive
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i != currentIndex)
            {
                gameObjects[i].SetActive(false);
            }
        }
    }

    public void GoToNextGameObject()
    {
        // deactivate the current game object
        gameObjects[currentIndex].SetActive(false);

        // increment the index
        currentIndex++;

        // wrap around to the beginning if we've reached the end of the array
        if (currentIndex >= gameObjects.Length)
        {
            currentIndex = 0;
        }

        // activate the next game object
        gameObjects[currentIndex].SetActive(true);
    }

    public void GoToPreviousGameObject()
    {
        // deactivate the current game object
        gameObjects[currentIndex].SetActive(false);

        // decrement the index
        currentIndex--;

        // wrap around to the end if we've reached the beginning of the array
        if (currentIndex < 0)
        {
            currentIndex = gameObjects.Length - 1;
        }

        // activate the previous game object
        gameObjects[currentIndex].SetActive(true);
    }

}
