using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerCrackSound, playerJumpSound;
    private static AudioSource audioSource;
  

    void Start()
    {
        playerCrackSound = Resources.Load<AudioClip>("eggCrack");
        playerJumpSound = Resources.Load<AudioClip>("EggyJump");
        //playerDeathSound = Resources.Load<AudioClip > ("EggyDeath");

        audioSource = GetComponent<AudioSource>();
    }
    /*
    void Awake()
    {
        Debug.Log(ApplicationActivator.loadedSceneName);

       // DontDestroyOnLoad(this.gameObject);

        soundtrack[0] = (AudioClip)ResourceScope.Load("MenuSoundtrack");

         
        if(ApplicationActivator.loadedSceneName == "MainMenu")
        {
            audioSource.clip[0];
            audioSource.Play();
        }
         

        if (instance != null)
        {
            Destroy(gameObject);
        }
    }
    */
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "eggCrack":
                audioSource.PlayOneShot(playerCrackSound);
                break;
            case "EggyJump":
                audioSource.PlayOneShot(playerJumpSound);
                break;
            /*case "EggyDeath":
                audioSource.PlayOneShot(playerDeathSound);
                break;
            */
        }
    }

}
