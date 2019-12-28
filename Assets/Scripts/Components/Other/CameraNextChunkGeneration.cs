using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNextChunkGeneration : MonoBehaviour
{
    public event Action EventTriggerEntered;

    private void OnTriggerEnter(Collider other)
    {
        EventTriggerEntered?.Invoke();
    }
}
