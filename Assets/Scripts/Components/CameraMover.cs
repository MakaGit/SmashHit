using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    void Update()
    {
        Vector3 forward = new Vector3(0.0f, 0.0f, 1.0f);

        float speed = 3.0f;

        Vector3 translation = forward * speed * Time.deltaTime;

        transform.position += translation;
    }
}
