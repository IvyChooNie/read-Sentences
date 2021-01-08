using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Windows.Speech;
using System.Collections.Generic;
using System.Linq;
using Proyecto26;
using UnityEngine.UI;

public class q06 : MonoBehaviour
{
    public Text scoreText;
    public InputField nameText;

    public static int playerScore;
    public static string playerName;

    KeywordRecognizer keywordRecognizer;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void Start()
    {
        keywords.Add("eight", () =>
        {
            GoCalled00();
        });

        keywords.Add("eraser", () =>
        {
            GoCalled01();
        });

        keywords.Add("pumpkin", () =>
        {
            GoCalled02();
        });

        keywords.Add("aeroplane", () =>
        {
            GoCalled03();
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
        ScoreBoard02.Score += 2;
        txtDisplay011.textDisplay011 += "+2";
        // scoreDisplay.scr -= 2;
        playerScore = ScoreBoard02.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }

    void GoCalled01()
    {
        Debug.Log("Excellent");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard02.Score += 2;
        txtDisplay012.textDisplay012 += "+2";
        // scoreDisplay.scr -= 2;
        playerScore = ScoreBoard02.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
    }

    void GoCalled02()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";

        ScoreBoard02.Score -= 2;
        playerScore = ScoreBoard02.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
        // scoreDisplay.scr -= 2;
    }

    void GoCalled03()
    {
        Debug.Log("Opps");
        //this.transform.Translate(Vector3.up * 10.0f);
        //txtDisplay.textDisplay += "heel";
        // txtDisplay2.textDisplay2 += "Wow! You are smart! It is a wheel.";
        ScoreBoard02.Score -= 2;
        playerScore = ScoreBoard02.Score;
        //playerScore = random.Next(0, 10);
        scoreText.text = "Score: " + playerScore;
        // scoreDisplay.scr -= 2;
    }

    public void OnSubmit()
    {
        playerName = nameText.text;
        PostToDatabase();
    }

    public void PostToDatabase()
    {
        User07 user = new User07();
        RestClient.Post("https://fyp-testing1.firebaseio.com/.json", user);
    }
}
