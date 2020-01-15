using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayPanel : MonoBehaviour
{
    [SerializeField]
    private Text _scoreLabe1 = null;
    [SerializeField]
    private Text _HealthPoints = null;

    private void OnEnable()
    {
        ScoreManager.Instance.EventCurrentScoreChanged += OnCurrentScoreChanged;
        PlayerManager.Instance.EventCurrentHealthPointsChanged += OnCurrentHealthPointsChanged;
        _scoreLabe1.text = ScoreManager.Instance.CurrentScore.ToString();
        _HealthPoints.text = PlayerManager.Instance.CurrentHealthPoints.ToString();
    }

    private void OnDisable()
    {
        ScoreManager.Instance.EventCurrentScoreChanged -= OnCurrentScoreChanged;
        PlayerManager.Instance.EventCurrentHealthPointsChanged -= OnCurrentHealthPointsChanged;
    }

    private void OnCurrentScoreChanged(int currentScore)
    {
        _scoreLabe1.text = currentScore.ToString();
    }

    private void OnCurrentHealthPointsChanged(int currentHealthPoints)
    {
        _HealthPoints.text = currentHealthPoints.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UserInterfaceManager.Instance.EnablePanel(UIPanelType.PausePanel);
        }
    }
}
