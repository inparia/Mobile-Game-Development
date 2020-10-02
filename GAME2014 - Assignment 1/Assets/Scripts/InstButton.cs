using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstButton : MonoBehaviour
{
    //creating buttons, and game objects
    public Button button;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        //Enable Button Click
        button.onClick.AddListener(SetButton);
    }

    private void Update()
    {
    }
    // Update is called once per frame

    public void SetButton()

    {
        //Displays Instruction Panel
        panel.gameObject.SetActive(true);
        //Disables instruction button
        button.gameObject.SetActive(false);
    }
}
