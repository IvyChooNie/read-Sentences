using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class T1q102 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {



        keywords.Add("cup", () =>
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

   
    void GoCalled02()
    {
        Debug.Log("Opps! You are wrong. It is a cat.");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplay3.textDisplay3 += "at";
        txtDisplay04.textDisplay4 += "X";
        txtDisplay2.textDisplay2 += "Opps! You are wrong.It is a cat.";
        ScoreBoardC01.Score -= 2;
        // scoreDisplay.scr -= 2;
    }

}
