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
            Time.timeScale = 0.75f;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == finishLine)
        {
            hasFinished = true;
        }
        if (collision.gameObject == nest)
        {
            endScreen.SetActive(true);
        }
    }

}
