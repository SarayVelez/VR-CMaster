using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionChecker : MonoBehaviour
{
    /*public RAMSocketColliderUno ramSocketColliderUno;
    public RAMSocketColliderDos ramSocketColliderDos;
    public PROCSocketCollider procSocketCollider;
    public HDDSocketCollider hddSocketCollider;
    public FUENTESocketCollider fuenteSocketCollider;
    public GPUSocketCollider gpuSocketCollider;
    public MOTHERSocketCollider motherSocketCollider;
    public Text resultText;*/

    public Text resultText;

    private List<MonoBehaviour> collisionScripts = new List<MonoBehaviour>();

    private void Start()
    {
        CollectCollisionScripts();
    }

    private void Update()
    {
        bool allCollisions = CheckAllCollisions();

        // Actualizar el texto según el resultado de la comprobación
        if (allCollisions)
        {
            resultText.text = "Todas las piezas están encajadas correctamente";
        }
        else
        {
            resultText.text = "Algunas piezas no están encajadas correctamente";
        }
    }

    private void CollectCollisionScripts()
    {
        RAMSocketColliderUno[] ramCollidersUno = FindObjectsOfType<RAMSocketColliderUno>();
        foreach (RAMSocketColliderUno collider in ramCollidersUno)
        {
            collisionScripts.Add(collider);
        }

        RAMSocketColliderDos[] ramCollidersDos = FindObjectsOfType<RAMSocketColliderDos>();
        foreach (RAMSocketColliderDos collider in ramCollidersDos)
        {
            collisionScripts.Add(collider);
        }

        PROCSocketCollider[] procColliders = FindObjectsOfType<PROCSocketCollider>();
        foreach (PROCSocketCollider collider in procColliders)
        {
            collisionScripts.Add(collider);
        }

        HDDSocketCollider[] hddColliders = FindObjectsOfType<HDDSocketCollider>();
        foreach (HDDSocketCollider collider in hddColliders)
        {
            collisionScripts.Add(collider);
        }

        FUENTESocketCollider[] fuenteColliders = FindObjectsOfType<FUENTESocketCollider>();
        foreach (FUENTESocketCollider collider in fuenteColliders)
        {
            collisionScripts.Add(collider);
        }

        GPUSocketCollider[] gpuColliders = FindObjectsOfType<GPUSocketCollider>();
        foreach (GPUSocketCollider collider in gpuColliders)
        {
            collisionScripts.Add(collider);
        }

        MOTHERSocketCollider[] motherColliders = FindObjectsOfType<MOTHERSocketCollider>();
        foreach (MOTHERSocketCollider collider in motherColliders)
        {
            collisionScripts.Add(collider);
        }
    }

    private bool CheckAllCollisions()
    {
        bool proc1Encajado = false;
        bool proc2Encajado = false;
        bool ram1Encajada = false;
        bool ram2Encajada = false;
        bool hddEncajado = false;
        bool fuenteEncajada = false;
        bool gpuEncajada = false;
        bool motherEncajada = false;

        // Revisa todos los scripts de colisión almacenados en la lista
        foreach (MonoBehaviour collisionScript in collisionScripts)
        {
            if (collisionScript is RAMSocketColliderUno)
            {
                ram1Encajada = ((RAMSocketColliderUno)collisionScript).ramunoEncajada;
            }
            else if (collisionScript is RAMSocketColliderDos)
            {
                ram2Encajada = ((RAMSocketColliderDos)collisionScript).ramdosEncajada;
            }
            else if (collisionScript is PROCSocketCollider)
            {
                proc1Encajado = ((PROCSocketCollider)collisionScript).proc1Encajado;
                proc2Encajado = ((PROCSocketCollider)collisionScript).proc2Encajado;
            }
            else if (collisionScript is HDDSocketCollider)
            {
                hddEncajado = ((HDDSocketCollider)collisionScript).hddEncajado;
            }
            else if (collisionScript is FUENTESocketCollider)
            {
                fuenteEncajada = ((FUENTESocketCollider)collisionScript).fontEncajada;
            }
            else if (collisionScript is GPUSocketCollider)
            {
                gpuEncajada = ((GPUSocketCollider)collisionScript).gpuEncajada;
            }
            else if (collisionScript is MOTHERSocketCollider)
            {
                motherEncajada = ((MOTHERSocketCollider)collisionScript).motEncajada;
            }
        }

        // Realiza las comprobaciones necesarias
        bool allCollisions = proc1Encajado && !proc2Encajado && ram1Encajada && ram2Encajada && hddEncajado && fuenteEncajada && gpuEncajada && motherEncajada;

        return allCollisions;
    }
}
