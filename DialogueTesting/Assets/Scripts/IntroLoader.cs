using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLoader : MonoBehaviour
{

    public void OnEnable()
    {
        SceneManager.LoadScene("DialogueTesting", LoadSceneMode.Single);
    }
}
