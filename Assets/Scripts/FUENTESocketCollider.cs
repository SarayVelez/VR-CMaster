using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FUENTESocketCollider : MonoBehaviour
{
    public bool fontEncajada = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FONT"))
        {
           fontEncajada = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
            if (other.gameObject.CompareTag("FONT"))
        {
           fontEncajada = false;
        }
    }
}
