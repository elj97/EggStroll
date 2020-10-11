using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassFinishLine : MonoBehaviour
{

    public GameObject finishLine;
    private bool hasFinished = false;
    public GameObject nest;
    public GameObject endScreen;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (hasFinished == false)
        {
            //Jumping and Player interaction of the egg
        }

        if (hasFinished == true)
        {
            //Change speed of sprite animation
            //Change speed of screen movement
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject == finishLine)
        {
            hasFinished = true;
        }
        if (collider.gameObject == nest)
        {
            endScreen.SetActive(true);
        }
    }

    
}
