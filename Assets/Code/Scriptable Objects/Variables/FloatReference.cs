using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
    public bool _useValue = true;
    public float _value;
    public FloatVariable _reference;
    
    public FloatReference()
    {

    }

    public FloatReference(float value)
    {
        _useValue = true;
        _value = value;
    }

    public float Value
    {
        get
        {
            return _useValue ? _value : _reference._value;
        }

        set
        {
            if (_useValue)
            {
                _value = value;
            } else
            {
                _reference.SetValue(value);
            }
        }
    }

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
