using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontrol : MonoBehaviour
{
    public static gamecontrol control;

    public Text LivesText;
    

    public Text score;
    public int scorevalue;
    public Text rotatorspeed;
    public int rotatorspeedvalue;
    public Text pinspeed;
    public int pinspeedvalue;
    public Text gametime;
    public int gametimevalue;

    private void Start()
    {
        LivesText.text = StateNameController.Lives;
    }



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
