using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PROCSocketCollider : MonoBehaviour
{
    public bool proc1Encajado = false;
    public bool proc2Encajado =false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PROC1"))
        {
           proc1Encajado = true;
        }
        if (other.gameObject.CompareTag("PROC2"))
        {
           proc2Encajado = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PROC1"))
        {
           proc1Encajado = false;
        }
        if (other.gameObject.CompareTag("PROC2"))
        {
           proc2Encajado = false;
        }
    }
}
