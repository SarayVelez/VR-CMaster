using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMSocketColliderUno : MonoBehaviour
{
    public bool ramunoEncajada = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RAM"))
        {
           ramunoEncajada = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("RAM"))
        {
           ramunoEncajada = false;
        }
    }
}
