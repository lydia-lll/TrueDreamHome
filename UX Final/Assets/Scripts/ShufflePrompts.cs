using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShufflePrompts : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
    public GameObject[] objectsToActivate;
    public GameObject oldObj;
    
    public void Shuffle(){
        for (int i = 0; i < objectsToDeactivate.Length; i++) 
        {
            objectsToDeactivate[i].SetActive(false);
        }
        oldObj.SetActive(false);
        int randomIndex = Random.Range(0, objectsToActivate.Length);
        GameObject activateTarget = objectsToActivate[randomIndex];
        activateTarget.SetActive(true);
        oldObj = activateTarget;
    }
}
