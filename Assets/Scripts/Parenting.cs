using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parenting : MonoBehaviour
{
    private Transform mainCameraTransform; // the transform of the main camera
    private Transform startingParent; // the starting parent of the object
    private Vector3 startingPositionRelativeToMainCamera; // the starting position of the object relative to the main camera
    private Quaternion startingRotationRelativeToMainCamera; // the starting rotation of the object relative to the main camera

    private void Start()
    {
        // store the transform of the main camera and the starting parent
        mainCameraTransform = Camera.main.transform;
        startingParent = transform.parent;

        // store the starting position of the object relative to the main camera
        startingPositionRelativeToMainCamera = mainCameraTransform.InverseTransformPoint(transform.position);
        startingRotationRelativeToMainCamera = Quaternion.Inverse(mainCameraTransform.rotation) * transform.rotation;

    }

    public void DelayedUnparentObject()
    {
        Invoke("UnparentObject", 0.25f); // unparent the object
    }

    public void ReparentObject()
    {
        {
            // calculate the position and rotation of the object relative to the main camera
            Vector3 positionRelativeToMainCamera = mainCameraTransform.TransformPoint(startingPositionRelativeToMainCamera);
            Quaternion rotationRelativeToMainCamera = mainCameraTransform.rotation * startingRotationRelativeToMainCamera;

            // reparent the object to its starting parent
            transform.parent = startingParent;

            // set the position and rotation of the object to its position and rotation relative to the main camera
            transform.position = positionRelativeToMainCamera;
            transform.rotation = rotationRelativeToMainCamera;
        }
        
    }
    
    public void UnparentObject()
    {
        transform.parent = null; // unparent the object from the main camera
    }
}
