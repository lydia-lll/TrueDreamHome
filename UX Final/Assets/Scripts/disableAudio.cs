using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableAudio : MonoBehaviour
{
    public GameObject LAaudio;
    public GameObject Italyaudio;
    public GameObject Finlandaudio;
    public void noAudio(){
        LAaudio.SetActive(false);
        Italyaudio.SetActive(false);
        Finlandaudio.SetActive(false);
    }
}
