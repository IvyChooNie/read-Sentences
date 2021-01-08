using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q003 : MonoBehaviour
{

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("king", () =>
        {
            GoCalled00();
        });

        keywords.Add("ring", () =>
        {
            GoCalled01();
        });

        keywords.Add("sing", () =>
        {
            GoCalled02();
        });

        keywords.Add("wing", () =>
        {
            GoCalled03();
        });

        keywords.Add("The king has a ring", () =>
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
        txtDisplay00010.textDisplay00010 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 3;
        txtDisplay00011.textDisplay00011 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 2;
        txtDisplay00012.textDisplay00012 += "x";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled03()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 2;
        txtDisplay00013.textDisplay00013 += "x";
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
        txtDisplay00014.textDisplay00014 += "The king has a ring.";
        // scoreDisplay.scr -= 2;
        // txtDisplay5.textDisplay5 += "x";
    }
}
