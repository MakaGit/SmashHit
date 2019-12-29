using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private GameObject _nonDestroyedDummy = null;
    [SerializeField]
    private GameObject _destroyedDummy = null;

    private void Awake()
    {
        _nonDestroyedDummy.SetActive(true);
        _destroyedDummy.SetActive(false);
    }

    private void OnVollisionEnter(Collision other)
    {
        _nonDestroyedDummy.SetActive(false);
        _destroyedDummy.SetActive(true);
    }
}
