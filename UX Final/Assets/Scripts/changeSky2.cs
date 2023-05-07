using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSky2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Material skybox;
    // Start is called before the first frame update

    public void ChangeSkybox(){
        RenderSettings.skybox = skybox;
    }
}
