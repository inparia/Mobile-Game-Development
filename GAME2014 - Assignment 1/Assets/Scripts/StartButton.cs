using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    //creating buttons, and game objects
    public Button button;
    public GameObject player, key;
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

        RockCollision ps = player.GetComponent<RockCollision>();
        ps.lifeOne.SetActive(true);
        ps.lifeTwo.SetActive(true);
        ps.lifeThree.SetActive(true);
        //Enable Player, Rock Panel
        player.gameObject.SetActive(true);
        key.SetActive(true);
        player.gameObject.transform.position = new Vector3(1100.0f, 150.0f, 0.0f);
        rockPanel.gameObject.SetActive(true);

        //Disables the buttons.
        mainPanel.gameObject.SetActive(false);
        textPanel.gameObject.SetActive(false);
    }

}
