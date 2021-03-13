using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    int Lives;
    void Start()
    {
        UpdateUI();

    }
    void UpdateUI()
    {

        Lives = PlayerPrefs.GetInt("Lives");

        GameObject.Find("livesUI").GetComponent<Text>().text = "Lives : " + Lives;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.name == "Life")
        {
            Destroy(collider.gameObject);
            Lives++;
            PlayerPrefs.SetInt("Lives", Lives);
        }
    }


    void OnCollisionEnter2D(Collision2D coll)

    {
        string tag = coll.collider.gameObject.tag;



        if (tag == "avoid_me")
        {

            Lives--;
            PlayerPrefs.SetInt("Lives", Lives);


            if (Lives > 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
