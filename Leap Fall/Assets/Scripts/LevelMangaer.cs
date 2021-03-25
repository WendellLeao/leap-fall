using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMangaer : MonoBehaviour
{

    public GameObject PainelPause;

    public bool isPaused = false;
    void Start()
    {

    }

    void Update()
    {
        if (isPaused == true)
        {          
            PainelPause.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }

        if(isPaused == false)
        {
            PainelPause.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    public void Pause()
    {
        PainelPause.SetActive(true);
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }
    public void Menu()
    {
        isPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MuteMenu");
    }

    public void Credits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lvl_1");
    }
}
