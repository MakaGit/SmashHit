using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    [SerializeField]
    private GameObject _nonDestroyedPrefab = null;
    [SerializeField]
    private GameObject _destroyedPrefab = null;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (!collision.collider.GetComponent<CollisionWave>())
            {
                collision.collider.gameObject.AddComponent<CollisionWave>();
            }

            if (!collision.collider.GetComponent<Rigidbody>())
            {
                collision.collider.gameObject.AddComponent<Rigidbody>();
            }
        }

        StartCoroutine(ExplosionPrefab(collision));

    }

    private void Awake()
    {
        _nonDestroyedPrefab.SetActive(true);
        _destroyedPrefab.SetActive(false);
    }

    private void Start()
    {
        Invoke("Destroing", 10.0f);
    }

    private void Destroing()
    {
        if (transform.position.y < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator ExplosionPrefab(Collision collision)
    {
        _nonDestroyedPrefab.SetActive(false);
        _destroyedPrefab.SetActive(true);
        var rigidbodies = _destroyedPrefab.GetComponentsInChildren<Rigidbody>();
        foreach (var body in rigidbodies)
        {
            body.AddExplosionForce(400.0f, collision.contacts[0].point, 5.0f);
        }

        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
}
