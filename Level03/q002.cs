using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q002 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("green", () =>
        {
            GoCalled00();
        });

        keywords.Add("grass", () =>
        {
            GoCalled01();
        });

        keywords.Add("grow", () =>
        {
            GoCalled02();
        });

        keywords.Add("great", () =>
        {
            GoCalled03();
        });

        keywords.Add("The grass is green.", () =>
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
        txtDisplay0005.textDisplay0005 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 3;
        txtDisplay0006.textDisplay0006 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 2;
        txtDisplay0007.textDisplay0007 += "x";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled03()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 2;
        txtDisplay0008.textDisplay0008 += "x";
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
        txtDisplay0009.textDisplay0009 += "The grass is green.";
        // scoreDisplay.scr -= 2;
        // txtDisplay5.textDisplay5 += "x";
    }
}