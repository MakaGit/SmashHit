using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PlayerLifeCollider"))
        {
            PlayerManager.Instance.ModifyHealthPoints(_damage);
        }
        Destroy(gameObject);
    }

    private void Start()
    {
        Invoke("Destroing", 10.0f);
    }

    private void Destroing()
    {
            Destroy(gameObject);
    }
}
