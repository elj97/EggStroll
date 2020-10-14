using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {

            RestartLevel();
        }
    }

    /* void Start()
     {
         if (ClassName.playRestartSound)
         {
             ClassName.playRestartSound = false;
             audioSource.Play();
         }
     }*/

    public void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
