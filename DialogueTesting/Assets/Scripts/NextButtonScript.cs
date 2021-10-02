using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextButtonScript : MonoBehaviour
{

    private InkManager _inkManager;

    // Start is called before the first frame update
    void Start()
    {
        _inkManager = FindObjectOfType<InkManager>();

        if (_inkManager == null)
        {
            Debug.LogError("Ink Manager was not found !");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        _inkManager?.DisplayNextLine();
    }
}
