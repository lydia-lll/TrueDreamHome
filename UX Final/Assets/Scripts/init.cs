using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    public Material defaultSky;
    public GameObject map;
    public GameObject teleportPanel;
    public GameObject moveBtn;
    public GameObject locoBtn;
    public GameObject LAaudio;
    public GameObject Italyaudio;
    public GameObject Finlandaudio;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = defaultSky;
        map.SetActive(false);
        teleportPanel.SetActive(false);
        locoBtn.SetActive(false);
        moveBtn.SetActive(false);
        // locoBtn.SetActive(false);
        LAaudio.SetActive(false);
        Italyaudio.SetActive(false);
        Finlandaudio.SetActive(false);
    }

}
