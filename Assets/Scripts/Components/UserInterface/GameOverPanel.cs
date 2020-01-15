using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0.0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1.0f;
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitToMainMenuButtonClick()
    {
        UserInterfaceManager.Instance.EnablePanel(UIPanelType.MainMenuPanel);
    }

    public void OnExitGameButtonClick()
    {
    }
}
