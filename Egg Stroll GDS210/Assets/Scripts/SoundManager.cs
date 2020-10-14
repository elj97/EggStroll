using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip playerCrackSound, playerJumpSound;
    private static AudioSource audioSource;

    void Start()
    {

        playerCrackSound = Resources.Load<AudioClip>("eggCrack");
        playerJumpSound = Resources.Load<AudioClip>("jump");

        audioSource = GetComponent<AudioSource>();
    }

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
            case "jump":
                audioSource.PlayOneShot(playerJumpSound);
                break;
        }
    }

}
