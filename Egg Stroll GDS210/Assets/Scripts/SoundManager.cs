using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerCrackSound, playerDeathSound, playerJumpSound, playerWinSound;
    private static AudioSource audioSource;
  

    void Start()
    {
        playerDeathSound = Resources.Load<AudioClip>("deadegg");
        playerJumpSound = Resources.Load<AudioClip>("eggyJump");
        playerWinSound = Resources.Load<AudioClip>("victorySound");
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
            /*case "eggCrack":
                audioSource.PlayOneShot(playerCrackSound);
                break;*/
            case "eggyJump":
                audioSource.PlayOneShot(playerJumpSound);
                break;
            case "victorySound":
                audioSource.PlayOneShot(playerWinSound);
                break;
            case "deadegg":
                audioSource.PlayOneShot(playerDeathSound);
                break;
            
            
        }
    }

}
