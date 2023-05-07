using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSky : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skybox1;
    }

    public void ChangeSkybox(){
        RenderSettings.skybox = skybox2;
    }
    
}
