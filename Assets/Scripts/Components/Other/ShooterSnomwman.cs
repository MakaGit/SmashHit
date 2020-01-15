using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterSnomwman : MonoBehaviour
{
    public Rigidbody Ball;
    private Vector3 ShotDirection = new Vector3(0.0f, 0.0f, 0.0f);
    [SerializeField]
    private Transform _fireSpot = null;

    private void ThrowBall(Vector3 direction, Transform transform)
    {
        Rigidbody BallClone = (Rigidbody)Instantiate(Ball, transform.position, transform.rotation);
        BallClone.velocity = direction * EnemyManager.Instance.EnemyBallThrowingSpeed;
    }

    void Start()
    {
        InvokeRepeating("LaunchProjectile", 3.0f, Random.Range(EnemyManager.Instance.EnemyReloadingTimeMin, EnemyManager.Instance.EnemyReloadingTimeMax));
    }

    private void LaunchProjectile()
    {
            ShotDirection = EnemyManager.Instance.CameraPosition - _fireSpot.position;

            Ray ray = new Ray(_fireSpot.position, ShotDirection);

            Debug.DrawRay(_fireSpot.position, ShotDirection, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("PlayerLifeCollider"))
                {
                    if (hit.distance <= EnemyManager.Instance.EnemyAttackRange)
                    {
                    Debug.Log(hit.distance);
                        ThrowBall(ray.direction, _fireSpot);
                    }
                }
            }
    }
}
