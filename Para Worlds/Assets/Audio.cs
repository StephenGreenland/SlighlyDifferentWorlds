using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    FMOD.Studio.EventInstance Amb;
    // Start is called before the first frame update
    void Start()
    {
        Amb = FMODUnity.RuntimeManager.CreateInstance("event:/Environment/Ambience/Ambience");
        Amb.start(); 
    }
}
