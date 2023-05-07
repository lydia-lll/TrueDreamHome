using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disActive : MonoBehaviour
{
    public GameObject gameObject2;
    

    public void disActiveObj()
    {
        gameObject2.SetActive(false);
    }
}
