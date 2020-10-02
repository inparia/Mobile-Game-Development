using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public Button button;
    public Button buttonTwo;
    public Button buttonThree;
    public GameObject player;
    public Text instText;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(SetButton);
    }

    private void Update()
    {
    }
    // Update is called once per frame

    public void SetButton()

    {
        player.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
        buttonTwo.gameObject.SetActive(false);
        instText.gameObject.SetActive(false);
        buttonThree.gameObject.SetActive(false);
    }

}
