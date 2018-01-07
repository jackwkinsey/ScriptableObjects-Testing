using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : MonoBehaviour
{
    [SerializeField]
    private Vector2Variable _movementVector;
	
	private void Update ()
	{
		if (_movementVector.value != Vector2.zero)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back, _movementVector.value);
        }
	}
}
