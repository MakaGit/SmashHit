using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerlayPanel : MonoBehaviour
{
    [SerializeField]
    private Text _scoreLabe1 = null;

    private void OnEnable()
    {
        ScoreManager.Instance.EventCurrentScoreChanged += OnCurrentScoreChanget;
    }

    private void OnDisable()
    {
        ScoreManager.Instance.EventCurrentScoreChanged -= OnCurrentScoreChanget;
    }

    private void OnCurrentScoreChanget(int currentScore)
    {
        _scoreLabe1.text = currentScore.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }
}
