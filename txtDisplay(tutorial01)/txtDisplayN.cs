using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class txtDisplayN : MonoBehaviour
{
    public static string textDisplayN = "";

    Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = textDisplayN;
    }

}
