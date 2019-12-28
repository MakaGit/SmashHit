using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private float _speed = 0.0f;

    void Update()
    {
        var settingsManager = SettingsManager.Instance;
        _speed = settingsManager.CameraSpeed;

        Vector3 translation = Vector3.forward * _speed * Time.deltaTime;

        transform.position += translation;
    }
}

