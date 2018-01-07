using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField]
    private FloatReference _HP;

    [SerializeField]
    private FloatVariable _MaxHP;

    [SerializeField]
    private bool _resetHP;


	private void Start ()
	{
		if (_resetHP)
        {
            _HP.Value = _MaxHP._value;
        }
	}
	
	private void Update ()
	{
		if (_HP.Value <= 0.0f)
        {
            // die
            // death event?
            Debug.Log("DIE!!!");
            Destroy(gameObject);
        }
	}

    public void TakeDamage(float damageAmount)
    {
        _HP.Value -= damageAmount;
        // damage event?
    }

    public void Heal(float healingAmount)
    {
        if (_HP.Value < _MaxHP._value)
        {
            _HP.Value += healingAmount;
            // heal event?
        }

        if (_HP.Value > _MaxHP._value)
        {
            _HP.Value = _MaxHP._value;
        }
    }

    // So other scripts can get the current percentage of
    // any other object with the UnitHealth script.
    public float GetCurrentHealthPercentage()
    {
        return _HP.Value / _MaxHP._value;
    }
}
