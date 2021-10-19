using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPause : MonoBehaviour
{

    [SerializeField] 
    private GameObject pauseMenuUI;

    [SerializeField] 
    private bool isPaused;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
      
        pauseMenuUI.SetActive(true);
        AudioListener.pause = true;
        
    }

    public void DeactivateMenu()
    {
        
        pauseMenuUI.SetActive(false);
        AudioListener.pause = false;
        isPaused = false;
    }
}
