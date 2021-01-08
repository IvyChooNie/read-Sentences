using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q006 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("the baby likes to eat berries and bananas", () =>
        {
            GoCalled00();
        });

        keywords.Add("the berries like to eat baby and bananas", () =>
        {
            GoCalled01();
        });

        keywords.Add("the bananas like to eat berries and baby", () =>
        {
            GoCalled02();
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
        ScoreBoard03.Score += 5;
        txtDisplay00025.textDisplay00025 += "+5";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 5;
        txtDisplay00026.textDisplay00026 += "x";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 5;
        txtDisplay00027.textDisplay00027 += "x";
        // scoreDisplay.scr -= 2;
    }
}
