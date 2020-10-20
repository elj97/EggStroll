using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSound : MonoBehaviour
{
    //public AudioSource fallSource;
    public static AudioClip playerCrackSound, playerDeathSound, playerJumpSound, playerWinSound;
    private static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       // fallSource = GetComponent<AudioSource>();
        playerDeathSound = Resources.Load<AudioClip>("deadegg");
        playerJumpSound = Resources.Load<AudioClip>("eggyJump");
        playerWinSound = Resources.Load<AudioClip>("victorySound");


        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SoundManager.PlaySound("deadegg");

           // fallSource.Play();

           
        }
    }
}
