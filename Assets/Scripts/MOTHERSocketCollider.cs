using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOTHERSocketCollider : MonoBehaviour
{
    public bool motEncajada = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MOT"))
        {
          motEncajada  = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MOT"))
        {
          motEncajada  = false;
        }
    }
}
