using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;

public class q007 : MonoBehaviour
{ 
    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("the xenop lays eggs in the nest", () =>
        {
            GoCalled00();
        });

        keywords.Add("the shark lays eggs in the nest", () =>
        {
            GoCalled01();
        });

        keywords.Add("the xenop lays eggs in the tree", () =>
        {
            GoCalled02();
        });


        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizerOnPhraseRecognizer;
        keywordRecognizer.Start();

        playerScore = ScoreBoard03.Score;
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

    void GoCalled00()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score += 5;
        txtDisplay00028.textDisplay00028 += "+5";
        // scoreDisplay.scr -= 2;
        playerScore = ScoreBoard03.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard03.Score -= 3;
        txtDisplay00029.textDisplay00029 += "x";
        // scoreDisplay.scr -= 2;
        playerScore = ScoreBoard03.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay6.textDisplay6 += "x";
        ScoreBoard03.Score -= 5;
        txtDisplay00030.textDisplay00030 += "x";
        // scoreDisplay.scr -= 2;
        playerScore = ScoreBoard03.Score;
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
        User06 user = new User06();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }
}