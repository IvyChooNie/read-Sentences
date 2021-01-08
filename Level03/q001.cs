using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q001 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("uncle", () =>
        {
            GoCalled00();
        });

        keywords.Add("umbrella", () =>
        {
            GoCalled01();
        });

        keywords.Add("uniform", () =>
        {
            GoCalled02();
        });

        keywords.Add("unicorn", () =>
        {
            GoCalled03();
        });

        keywords.Add("The uncle is holding an umbrella", () =>
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
        txtDisplay0.textDisplay0 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 3;
        txtDisplay0001.textDisplay0001 += "/";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 2;
        txtDisplay0002.textDisplay0002 += "x";
        // scoreDisplay.scr -= 2;
    }

    void GoCalled03()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 2;
        txtDisplay0003.textDisplay0003 += "x";
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
        txtDisplay0004.textDisplay0004 += "The uncle is holding an umbrella.";
        // scoreDisplay.scr -= 2;
        // txtDisplay5.textDisplay5 += "x";
    }


}
