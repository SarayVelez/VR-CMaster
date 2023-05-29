using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBios : MonoBehaviour
{
    public Transform objectToRotate;
    public Vector3 rotationAmount = new Vector3(0, 90, 0);

    public void RotateObject()
    {
        objectToRotate.Rotate(rotationAmount);
    }

}
