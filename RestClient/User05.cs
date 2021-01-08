using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User05
{
    public string userName;
    public int userScore;

    public User05()
    {
        userScore = q10.playerScore;
        userName = q10.playerName;
    }
}
