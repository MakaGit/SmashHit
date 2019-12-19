using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance = null;

    [SerializeField]
    public float CameraSpeed = 2.0f;
    [SerializeField]
    public List<Chunk> ChunkList = null;
    [SerializeField]
    public List<GameObject> TargetPrefabs = null;

    private void Start()
    {
        Instance = this;
    }
}
