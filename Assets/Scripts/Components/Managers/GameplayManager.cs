using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    void Start()
    {
        var settingsManager = SettingsManager.Instance;
        int index = Random.Range(0, settingsManager.ChunkList.Count);
        var chunkPrefab = settingsManager.ChunkList[index];
        var newChunk = Instantiate(chunkPrefab);
    }

}
