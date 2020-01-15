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
    [SerializeField]
    public List<GameObject> WallPrefabs = null;
    [SerializeField]
    public List<GameObject> ItemPrefabs = null;
    [SerializeField]
    public int NumberOfBackChunks = 3;
    [SerializeField]
    public int NumberOfFrontChunks = 10;
    [SerializeField]
    public float BallThrowingSpeed = 1.0f;


    private void Start()
    {
        Instance = this;
    }
}
