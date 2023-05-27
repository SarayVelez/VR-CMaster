using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reticleRotation : MonoBehaviour
{
   

    void Update() {
    transform.Rotate(0, 3, 0, Space.World);
    }
}
