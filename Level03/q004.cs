using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q004 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("doctor", () =>
        {
            GoCalled00();
        });

        keywords.Add("driver", () =>
        {
            GoCalled01();
        });

        keywords.Add("dustbin", () =>
        {
            GoCalled02();
        });

        keywords.Add("dolphin", () =>
        {
            GoCalled03();
        });

        keywords.Add("The driver is a doctor.", () =>
        {
            GoCalled04();
        });

        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognizer;
        keywordRecognizer.Start();

    }



    void KeywordRecognizerOnPhraseRecognizer(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;

        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }

    }

    void GoCalled00()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 3;
        txtDisplay00015.textDisplay00015 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 3;
        txtDisplay00016.textDisplay00016 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 2;
        txtDisplay00017.textDisplay00017 += "x";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled03()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 2;
        txtDisplay00018.textDisplay00018 += "x";
        // scoreDisplay.scr -= 2;
        // txtDisplay5.textDisplay5 += "x";
    }

    void GoCalled04()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 2;
        txtDisplay00019.textDisplay00019 += "The driver is a doctor.";
        // txtDisplay5.textDisplay5 += "x";
    }
}
