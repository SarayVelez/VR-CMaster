using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUSocketCollider : MonoBehaviour
{
    public bool gpuEncajada = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GPU"))
        {
           gpuEncajada  = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GPU"))
        {
           gpuEncajada  = false;
        }
    }
}
