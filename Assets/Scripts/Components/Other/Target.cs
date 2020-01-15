using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private GameObject _nonDestroyedDummy = null;
    [SerializeField]
    private GameObject _destroyedDummy = null;
    [SerializeField]
    private int _score = 1;
    [SerializeField]
    private int health = 2;

    private bool _isDestroyed = false;

    private void Awake()
    {
        _nonDestroyedDummy.SetActive(true);
        _destroyedDummy.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_isDestroyed)
        {
            return;
        }

        if (collision.collider.CompareTag("PlayerProjectile"))
        {
            health--;

            if (health == 0)
            {
                ScoreManager.Instance.ModifyScore(_score);

                _nonDestroyedDummy.SetActive(false);
                _destroyedDummy.SetActive(true);

                var rigidbodies = _destroyedDummy.GetComponentsInChildren<Rigidbody>();
                foreach (var body in rigidbodies)
                {
                    body.AddExplosionForce(400.0f, collision.contacts[0].point, 5.0f);
                }

                _isDestroyed = true;
                Destroy(_nonDestroyedDummy);
            }
        }
    }
}
