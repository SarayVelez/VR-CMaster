using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionChecker : MonoBehaviour
{
    public Text resultText;

    public bool isRamUnoEncajada = false;
    public bool isRamDosEncajada = false;
    public bool isProc1Encajado = false;
    public bool isProc2Encajado = false;
    public bool isGpuEncajado = false;
    public bool isMotEncajado = false;
    public bool isFontEncajado = false;
    public bool isDiscEncajado = false;
    private void Start()
    {
        // Obtener referencia al objeto socket
        GameObject socketuno = GameObject.Find("Socket");

        // Obtener referencia al script RAMSocketCollider
        RAMSocketColliderUno rAMSocketColliderUno = socketuno.GetComponent<RAMSocketColliderUno>();

        // Acceder a la variable pública ramdosEncajada
        isRamUnoEncajada = rAMSocketColliderUno.ramunoEncajada;
        
        // Obtener referencia al objeto socket
        GameObject socketdos = GameObject.Find("Socket");

        // Obtener referencia al script RAMSocketCollider
        RAMSocketColliderDos ramSocketColliderDos = socketdos.GetComponent<RAMSocketColliderDos>();

        // Acceder a la variable pública ramdosEncajada
        isRamDosEncajada = ramSocketColliderDos.ramdosEncajada;

        // Obtener referencia al objeto socket
        GameObject sockettres = GameObject.Find("Socket");

        // Obtener referencia al script RAMSocketCollider
        PROCSocketCollider procSocketCollider = sockettres.GetComponent<PROCSocketCollider>();

        // Acceder a la variable pública ramdosEncajada
        isProc1Encajado = procSocketCollider.proc1Encajado;
        // Acceder a la variable pública ramdosEncajada
        isProc2Encajado = procSocketCollider.proc2Encajado;

         // Obtener referencia al objeto socket
        GameObject socketcuatro = GameObject.Find("Socket");

        // Obtener referencia al script RAMSocketCollider
        GPUSocketCollider gpuSocketCollider = socketcuatro.GetComponent<GPUSocketCollider>();

        // Acceder a la variable pública ramdosEncajada
        isGpuEncajado = gpuSocketCollider.gpuEncajada;

        // Obtener referencia al objeto socket
        GameObject socketcinco = GameObject.Find("Socket");

        // Obtener referencia al script RAMSocketCollider
        MOTHERSocketCollider motherSocketCollider = socketcinco.GetComponent<MOTHERSocketCollider>();

        // Acceder a la variable pública ramdosEncajada
        isMotEncajado = motherSocketCollider.motEncajada;

        // Obtener referencia al objeto socket
        GameObject socketseis = GameObject.Find("SocketFuente");

        // Obtener referencia al script RAMSocketCollider
        FUENTESocketCollider fuenteSocketCollider = socketseis.GetComponent<FUENTESocketCollider>();

        // Acceder a la variable pública ramdosEncajada
        isFontEncajado = fuenteSocketCollider.fontEncajada;

        // Obtener referencia al objeto socket
        GameObject socketsiete = GameObject.Find("SocketDisco");

        // Obtener referencia al script RAMSocketCollider
        HDDSocketCollider hddSocketCollider = socketsiete.GetComponent<HDDSocketCollider>();

        // Acceder a la variable pública ramdosEncajada
        isDiscEncajado = hddSocketCollider.hddEncajado;
    }

    private void Update()
    {
        bool allCollisions = (isRamUnoEncajada || isRamDosEncajada) && (isProc1Encajado || isProc2Encajado) 
                        && isGpuEncajado && isMotEncajado && isFontEncajado && isDiscEncajado;
        // Actualizar el texto según el resultado de la comprobación
        if (allCollisions)
        {
            resultText.text = "Alta";
        }
        else
        {
            resultText.text = "N/A";
        }
    }
}
