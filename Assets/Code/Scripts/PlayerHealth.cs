using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField]
    private FloatVariable _HP_Reference;
	
	void Update ()
	{
        _HP_Reference._value = _HP;
	}
}
