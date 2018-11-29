using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{

    [SerializeField] GameObject _grenadePrefab;
    [SerializeField] Transform _grenadeStartTransform;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newGrenade = Instantiate(_grenadePrefab);
            newGrenade.GetComponent<Transform>().position = _grenadeStartTransform.position;
            newGrenade.GetComponent<Transform>().rotation = _grenadeStartTransform.rotation;
        }
    }
}
