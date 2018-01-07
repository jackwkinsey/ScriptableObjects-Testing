using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _speed;

    [SerializeField]
    private Vector2Variable _movementVector;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CleanMovementVector();
        UpdateVelocity();
    }


    private void CleanMovementVector()
    {
        if (_movementVector.value.magnitude > 1)
        {
            _movementVector.value.Normalize();
        }
    }

    private void UpdateVelocity()
    {
        _rb.velocity = _movementVector.value * _speed._value;
    }
}
