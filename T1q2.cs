using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class T1q2 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("horn", () =>
        {
            GoCalled00();
        });



        keywords.Add("hen", () =>
        {
            GoCalled01();
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
        Debug.Log("Opps!");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplayA.textDisplayA += "and";
        txtDisplayB.textDisplayB += "Opps! You are wrong. This is a hand.";
        txtDisplayC.textDisplayC += "X";
        ScoreBoardC01.Score -= 3;
        //scoreDisplay.scr += 5;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }



    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplayF.textDisplayF += "and";
        txtDisplayB.textDisplayB += "Wow! You are smart! This is a hand.";
        ScoreBoardC01.Score += 3;
        // scoreDisplay.scr -= 2;
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


