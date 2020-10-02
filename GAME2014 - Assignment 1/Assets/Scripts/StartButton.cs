using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    //creating buttons, and game objects
    public Button button;
    public GameObject player;
    public GameObject textPanel, rockPanel, mainPanel;
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
        //Enable Player, Rock Panel
        player.gameObject.SetActive(true);
        rockPanel.gameObject.SetActive(true);

        //Disables the buttons.
        mainPanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
    }

}
