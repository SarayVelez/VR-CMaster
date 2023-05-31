using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDDSocketCollider : MonoBehaviour
{
    public bool hddEncajado = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HDD"))
        {
           hddEncajado = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HDD"))
        {
           hddEncajado = false;
        }
    }
}
