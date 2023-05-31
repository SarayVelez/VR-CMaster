using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMSocketColliderDos : MonoBehaviour
{
    public bool ramdosEncajada = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RAM"))
        {
           ramdosEncajada = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("RAM"))
        {
           ramdosEncajada = false;
        }
    }
}
