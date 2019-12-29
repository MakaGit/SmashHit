using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private CameraNextChunkGeneration _cameraTriggerHandler = null;

    private Chunk _currentChunk = null;

    private Queue<Chunk> _spawnedChunks = new Queue<Chunk>();

    void Start()
    {
        var settingsManager = SettingsManager.Instance;
        for (int i = 0; i < settingsManager.NumberOfFrontChunks; ++i)
        {
            SpawnNextChunk();
        }  
    }

    private void OnEnable()
    {
        _cameraTriggerHandler.EventTriggerEntered += OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void OnDisable()
    {
        _cameraTriggerHandler.EventTriggerEntered -= OnCameraEnteredNextChunkGenerationTrigger;
    }

    private void SpawnNextChunk()
    {
        var settingsManager = SettingsManager.Instance;
        int index = Random.Range(0, settingsManager.ChunkList.Count);
        var chunkPrefab = settingsManager.ChunkList[index];
        Chunk newChunk = Instantiate(chunkPrefab);

        if (_spawnedChunks.Count > 0)
        {
            newChunk.transform.position =_currentChunk.NextChunkSpawnPoint.position;
            newChunk.transform.rotation = _currentChunk.NextChunkSpawnPoint.rotation;
        }
        else
        {
            newChunk.transform.position = Vector3.zero;
            newChunk.transform.rotation = Quaternion.identity;
        }

        _currentChunk = newChunk;
        _spawnedChunks.Enqueue(newChunk);

        if (_spawnedChunks.Count > settingsManager.NumberOfFrontChunks + settingsManager.NumberOfBackChunks)
        {
            var chunkToDelete = _spawnedChunks.Dequeue();
            Destroy(chunkToDelete.gameObject);
        }
    }

    private void OnCameraEnteredNextChunkGenerationTrigger()
    {
        SpawnNextChunk();
    }

}
