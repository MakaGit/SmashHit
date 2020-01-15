using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public event Action<int> EventCurrentScoreChanged;

    public int CurrentScore { get; private set; }

    public void ModifyScore(int points)
    {
        CurrentScore += points;
        EventCurrentScoreChanged?.Invoke(CurrentScore);
    }

    private void Awake()
    {
        Instance = this;
    }


}
