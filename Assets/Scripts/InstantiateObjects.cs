using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateObjects : MonoBehaviour
{
    [System.Serializable]
    public class ButtonSpawnPair
    {
        public Button button;
        public Button deleteButton; // Botón de eliminación
        public GameObject prefabToInstantiate;
        public GameObject destinationObject;
        public bool isOccupied;
        public GameObject occupiedAlertCanvas;
    }

    public List<ButtonSpawnPair> buttonSpawnPairs = new List<ButtonSpawnPair>();

    public void SpawnObject(Button button)
    {
        foreach (ButtonSpawnPair pair in buttonSpawnPairs)
        {
            if (pair.button == button)
            {
                if (pair.isOccupied)
                {
                    // Mostrar el canvas de alerta
                    pair.occupiedAlertCanvas.SetActive(true);
                    return;
                }

                // Verificar si el socket ya está ocupado por otro objeto
                foreach (ButtonSpawnPair otherPair in buttonSpawnPairs)
                {
                    if (otherPair != pair && otherPair.isOccupied && otherPair.destinationObject == pair.destinationObject)
                    {
                        // Mostrar el canvas de alerta
                        pair.occupiedAlertCanvas.SetActive(true);
                        return;
                    }
                }

                GameObject spawnedObject = Instantiate(pair.prefabToInstantiate);
                spawnedObject.transform.position = pair.destinationObject.transform.position;
                spawnedObject.transform.rotation = pair.destinationObject.transform.rotation;
                spawnedObject.transform.SetParent(pair.destinationObject.transform);
                spawnedObject.SetActive(true); // Activar el objeto instanciado

                // Marcar el socket como ocupado
                pair.isOccupied = true;

                // Asignar la función de eliminación al botón de eliminación
                pair.deleteButton.onClick.AddListener(() => DeleteObject(spawnedObject, pair));

                break;
            }
        }
    }

    public void DeleteObject(GameObject obj, ButtonSpawnPair pair)
    {
        // Eliminar el objeto
        Destroy(obj);

        // Marcar el socket como desocupado
        pair.isOccupied = false;

        // Ocultar el canvas de alerta
        pair.occupiedAlertCanvas.SetActive(false);
    }
}
