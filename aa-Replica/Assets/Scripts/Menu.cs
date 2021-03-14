using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField playername;

    public void StartGame(string input)
    {
        Debug.Log("Player Name is:"  + playername.text);
        MySettings.playernamestr = playername.text;
        StateNameController.Lives = input;
        SceneManager.LoadScene("Main");
    }
}
