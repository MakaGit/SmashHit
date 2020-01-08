using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowing : MonoBehaviour
{

    public Rigidbody Ball;

    private void ThrowBall(Vector3 direction)
    {
        Rigidbody BallClone = (Rigidbody)Instantiate(Ball, transform.position + new Vector3(0, 0, 1), transform.rotation);
        BallClone.velocity = direction * SettingsManager.Instance.BallThrowingSpeed;
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