using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceManager : MonoBehaviour
{
    [SerializeField]
    private GameplayPanel _gameplayPanel = null;
    [SerializeField]
    private PausePanel _pausePanel = null;

    public void EnablePanel(UIPanelType)
    {
        UserInterfaceManager.Instance.EnablePanel(UiPanelTupe)
    }
}
