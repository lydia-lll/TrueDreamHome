using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCollision : MonoBehaviour
{
    public GameObject btn;
    private void OnTriggerEnter(Collider other)
    {
        // if (other.tag == "Player"){
        //     btn.SetActive(true);
        //     Debug.Log("enter!");
        // }
        btn.SetActive(true);
        Debug.Log("enter!");
        Debug.Log(other.name);
    }
}
