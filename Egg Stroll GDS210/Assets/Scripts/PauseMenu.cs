using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenu = null;

    void Awake()
    {
        gamePaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == false)
            {
                PauseGame();
            }
            else
            {
                UnPauseGame();
            }
        }
    }

    public void TogglePause()
    {
        if (gamePaused == false)
        {
            PauseGame();
        }
        else
        {
            UnPauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.000001f;
        gamePaused = true;
    }

    public void UnPauseGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Settings()
    {
        Debug.Log("There ain't no settings!");
    }

    public void LevelSelect()
    {
        Debug.Log("There's only one level!");
    }
}
