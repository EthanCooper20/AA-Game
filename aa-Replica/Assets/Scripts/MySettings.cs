using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MySettings : MonoBehaviour
{
    public static string playernamestr;


    public Text playername;

    void Start ()
    {
        playername.text = playernamestr;
    }
   
}
