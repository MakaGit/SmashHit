using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;

    void Update()
    {
        Vector3 translation = Vector3.forward * _speed * Time.deltaTime;

        transform.position += translation;
    }
}

