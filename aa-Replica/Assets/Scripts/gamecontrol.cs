using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontrol : MonoBehaviour
{
    public static gamecontrol control;

    public Text score;
    public int scorevalue;
    public Text lives;
    public Text playername;
    public int currentlives;
    public InputField inputname;
    public string stringofname;



    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }



    }
    //gamecontrol.control.currentlives
}
