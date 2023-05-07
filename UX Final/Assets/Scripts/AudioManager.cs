using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // public GameObject[] objectsToDeactivate;
    public GameObject[] objectsToActivate;
    int audioIndex = 0;
    // public GameObject oldObj;
    
    public void AudioPlay(){
        // for (int i = 0; i < objectsToActivate.Length; i++) 
        // {
        //     objectsToDeactivate[i].SetActive(false);
        // }
        // oldObj.SetActive(false);
        // int randomIndex = Random.Range(0, objectsToActivate.Length);
        // GameObject activateTarget = objectsToActivate[randomIndex];
        // activateTarget.SetActive(true);
        // oldObj = activateTarget;
        if(audioIndex>0){
            objectsToActivate[audioIndex-1].SetActive(false);
        }
        objectsToActivate[audioIndex].SetActive(true);
        audioIndex+=1;
        if(audioIndex==objectsToActivate.Length){
            audioIndex=0;
        };
    }

    public void AudioPause(){
        for (int i = 0; i < objectsToActivate.Length; i++) 
        {
            objectsToActivate[i].SetActive(false);
        }
    }
}
