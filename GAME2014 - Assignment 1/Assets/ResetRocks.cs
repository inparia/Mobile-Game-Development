using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetRocks : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Reset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        gameObject.SetActive(true);
    }
}
