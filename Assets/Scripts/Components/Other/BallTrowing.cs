using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrowing : MonoBehaviour
{

    public Rigidbody Ball;
    public float speed = 10f;

    private void ThrowBall(Vector3 direction)
    {
        Rigidbody BallClone = (Rigidbody)Instantiate(Ball, transform.position, transform.rotation);
        BallClone.velocity = direction * 3 * speed;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                ThrowBall(ray.direction);
                
            }
        }
    }
}