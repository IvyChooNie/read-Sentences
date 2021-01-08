using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class T1q1 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("cat", () =>
        {
            GoCalled00();
        });

        keywords.Add("left", () =>
        {
            GoCalled05();
        });

        keywords.Add("right", () =>
        {
            GoCalled06();
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
        Debug.Log("Excellent. It is a cat.");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplay.textDisplay += "at";
        txtDisplay2.textDisplay2 += "Wow! You are smart! It is a cat.";
        //scoreDisplay.scr += 5;
        ScoreBoardC01.Score += 3;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }

    void GoCalled05()
    {

        ScoreBoardC01.Score += 2;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }

    void GoCalled06()
    {

        ScoreBoardC01.Score -= 2;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }

   
}
