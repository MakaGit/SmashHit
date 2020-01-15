using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingOnCamera : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(EnemyManager.Instance.CameraPosition);
        var correction = Quaternion.Euler(-90.0f, 90.0f, 0.0f);
        transform.rotation = transform.rotation * correction;
    }
}
