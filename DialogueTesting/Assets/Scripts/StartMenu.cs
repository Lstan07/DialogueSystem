using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene("NewIntro");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("i have quit");
    }
}
