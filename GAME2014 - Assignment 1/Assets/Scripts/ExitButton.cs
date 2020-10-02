using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{

    // Creating objects
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        //Enable Button Click
        button.onClick.AddListener(SetButton);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetButton()

    {
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
