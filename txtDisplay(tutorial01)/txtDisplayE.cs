using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class txtDisplayE : MonoBehaviour
{
    public static string textDisplayE = "";

    Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = textDisplayE;
    }
}
