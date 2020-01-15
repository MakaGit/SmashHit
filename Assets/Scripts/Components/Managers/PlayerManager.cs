using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public event Action<int> EventCurrentHealthPointsChanged;

    public int CurrentHealthPoints { get; private set; }

    public void ModifyHealthPoints(int points)
    {
        CurrentHealthPoints -= points;
        if (CurrentHealthPoints == 0)
        {
            UserInterfaceManager.Instance.EnablePanel(UIPanelType.GameOverPanel);
        }
        if (CurrentHealthPoints >= 100)
        {
            CurrentHealthPoints = 100;
        }
        EventCurrentHealthPointsChanged?.Invoke(CurrentHealthPoints);
    }


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CurrentHealthPoints = 100;
        EventCurrentHealthPointsChanged?.Invoke(CurrentHealthPoints);
    }
}
