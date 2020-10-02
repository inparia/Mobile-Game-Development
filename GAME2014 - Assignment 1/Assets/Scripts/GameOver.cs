using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Button button;
    public GameObject endPanel, mainPanel;
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
        endPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
