using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Grenade : MonoBehaviour
{
	[SerializeField] GameObject _explosionPrefab;
	
	Rigidbody _rigidbody;
	Transform _transform;

	void Start()
	{
		_transform = GetComponent<Transform>();
		_rigidbody = GetComponent<Rigidbody>();
		_rigidbody.AddForce(_transform.forward*30f,ForceMode.Impulse);
		
	}

	void OnCollisionEnter(Collision other)
	{
		Instantiate(_explosionPrefab,_transform.position,Quaternion.identity);
		Destroy(gameObject);
	}
}
