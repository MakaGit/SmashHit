using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWave : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (!collision.collider.GetComponent<Rigidbody>())
            {
                collision.collider.gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}
