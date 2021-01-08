using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;


public class q10 : MonoBehaviour
{

    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("view", () =>
        {
            GoCalled00();
        });



        keywords.Add("hold", () =>
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

        playerScore = ScoreBoardC01.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
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
        txtDisplayGG.textDisplayGG += "heel";
        txtDisplayHH.textDisplayHH += "Opps! You are wrong. It is a wheel.";
        txtDisplayII.textDisplayII += "X";
        ScoreBoardC01.Score -= 3;
        playerScore = ScoreBoardC01.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
        //scoreDisplay.scr += 5;
        // txtDisplay.textDisplay += "Excellent. It is a cat.";
    }



    void GoCalled00()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        txtDisplayJJ.textDisplayJJ += "heel";
        txtDisplayHH.textDisplayHH += "Wow! You are smart! It is a wheel.";
        ScoreBoardC01.Score += 3;
        playerScore = ScoreBoardC01.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
        // scoreDisplay.scr -= 2;
    }




    void GoCalled05()
    {

        ScoreBoardC01.Score += 2;

       
        playerScore = ScoreBoardC01.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }

    void GoCalled06()
    {

        ScoreBoardC01.Score -= 2;

     
        playerScore = ScoreBoardC01.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }


    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void PostToDatabase()
    {
        User05 user = new User05();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }

}
