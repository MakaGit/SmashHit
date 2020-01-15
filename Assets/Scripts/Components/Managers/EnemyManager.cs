using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance = null;

    [SerializeField]
    public float EnemyBallThrowingSpeed = 1.0f;
    [SerializeField]
    public float EnemyAttackRange = 1.0f;
    [SerializeField]
    public float EnemyReloadingTimeMin = 1.0f;
    [SerializeField]
    public float EnemyReloadingTimeMax = 1.0f;
    [HideInInspector]
    public Vector3 CameraPosition;

    void Update()
    {
        CameraPosition = Camera.main.transform.position;
    }

    private void Awake()
    {
        Instance = this;
    }
}
