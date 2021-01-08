using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User07
{
    public string userName;
    public int userScore;

    public User07()
    {
        userScore = q06.playerScore;
        userName = q06.playerName;
    }
}

