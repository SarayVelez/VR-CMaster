using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionChecker : MonoBehaviour
{
    public RAMSocketColliderUno ramSocketColliderUno;
    public RAMSocketColliderDos ramSocketColliderDos;
    public PROCSocketCollider procSocketCollider;
    public HDDSocketCollider hddSocketCollider;
    public FUENTESocketCollider fuenteSocketCollider;
    public GPUSocketCollider gpuSocketCollider;
    public MOTHERSocketCollider motherSocketCollider;

    public Text resultText;

    private void Update()
    {
        bool allCollisions = (ramSocketColliderUno.ramunoEncajada || ramSocketColliderDos.ramdosEncajada) &&
                         (procSocketCollider.proc1Encajado || procSocketCollider.proc2Encajado) &&
                         hddSocketCollider.hddEncajado &&
                         fuenteSocketCollider.fontEncajada &&
                         gpuSocketCollider.gpuEncajada &&
                         motherSocketCollider.motEncajada;

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
}
