using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    void Awake(){
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1080, 1920, true);
    }
    void Start(){
        Screen.SetResolution(1080, 1920, true);
    }
}