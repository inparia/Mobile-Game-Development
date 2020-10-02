using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstButton : MonoBehaviour
{
    public Button button;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.gameObject.SetActive(false);
        button.onClick.AddListener(SetButton);
    }

    private void Update()
    {
    }
    // Update is called once per frame

    public void SetButton()

    {
        text.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
    }
}
