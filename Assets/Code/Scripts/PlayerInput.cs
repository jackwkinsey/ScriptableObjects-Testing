using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Vector2Variable _movementVector;

    private Vector2 _lastMove;

    private float _xInput;
    private float _yInput;

    private bool _melee;

    private void Start()
    {
        
    }

    private void Update()
    {
        GetInput();
        ProcessInput();
    }

    private void GetInput()
    {
        _xInput = Input.GetAxis("Horizontal");
        _yInput = Input.GetAxis("Vertical");

        _melee = Input.GetButtonDown("MeleeAttack");
    }

    private void ProcessInput()
    {
        _movementVector.value = new Vector2(_xInput, _yInput);

        if (_movementVector.value != Vector2.zero)
            _lastMove = _movementVector.value;

        if (_melee)
        {
            gameObject.GetComponent<MeleeAttack>().Trigger(_lastMove);
        }
    }
}
