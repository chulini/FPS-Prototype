using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayed : MonoBehaviour
{

	[SerializeField] float _seconds;
	void Start () {
		Destroy(gameObject,_seconds);	
	}
	
}
