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
    public int currentlives;
    public Text rotatorspeed;
    public int rotatorspeedvalue;
    public Text pinspeed;
    public int pinspeedvalue;
    public Text gametime;
    public int gametimevalue;



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
