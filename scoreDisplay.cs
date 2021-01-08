using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour
{
    public static int score = 0;

    Text scr;

    void Start()
    {
        scr = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scr.text = "Score: " + score;
    }
}
