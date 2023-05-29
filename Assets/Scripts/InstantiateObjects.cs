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
        public GameObject prefabToInstantiate;
        public GameObject destinationObject;
    }

    public List<ButtonSpawnPair> buttonSpawnPairs = new List<ButtonSpawnPair>();

    public void SpawnObject(Button button)
    {
        foreach (ButtonSpawnPair pair in buttonSpawnPairs)
        {
            if (pair.button == button)
            {
                GameObject spawnedObject = Instantiate(pair.prefabToInstantiate);
                spawnedObject.transform.position = pair.destinationObject.transform.position;
                spawnedObject.transform.rotation = pair.destinationObject.transform.rotation;
                spawnedObject.transform.SetParent(pair.destinationObject.transform);
                break;
            }
        }
    }
}
