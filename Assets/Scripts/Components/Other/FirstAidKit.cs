using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    [SerializeField]
    private int _heal = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PlayerProjectile"))
        {
            PlayerManager.Instance.ModifyHealthPoints(-(_heal));
            Destroy(gameObject);
        }
    }
}
