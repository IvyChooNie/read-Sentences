using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;

public class q9 : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("gold", () =>
        {
            GoCalled00();
        });



        keywords.Add("good", () =>
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
    void GoCalled01()
    {
        Debug.Log("Opps!");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplayCC.textDisplayCC += "old";
        txtDisplayDD.textDisplayDD += "Opps! You are wrong. The answer is gold.";
        txtDisplayEE.textDisplayEE += "X";
        ScoreBoardC01.Score -= 3;
        //scoreDisplay.scr += 5;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }



    void GoCalled00()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplayFF.textDisplayFF += "old";
        txtDisplayDD.textDisplayDD += "Wow! You are smart! The answer is gold.";
        ScoreBoardC01.Score += 3;
        // scoreDisplay.scr -= 2;
    }




    void GoCalled05()
    {

        ScoreBoardC01.Score -= 2;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }

    void GoCalled06()
    {

        ScoreBoardC01.Score += 2;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }
}

