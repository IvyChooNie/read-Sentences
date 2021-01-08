using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User06
{
    public string userName;
    public int userScore;

    public User06()
    {
        userScore = q007.playerScore;
        userName = q007.playerName;
    }
}
