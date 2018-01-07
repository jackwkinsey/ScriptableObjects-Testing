using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Health : MonoBehaviour
{
    protected float _HP;

    [SerializeField]
    private FloatVariable _maxHP;

    [SerializeField]
    private UnityEvent _damageEvent;

    [SerializeField]
    private UnityEvent _deathEvent;

    [SerializeField]
    private UnityEvent _healEvent;

    public float HP
    {
        get
        {
            return _HP;
        }

        set
        {
            _HP = value;
        }
    }

    void Start ()
	{
        _HP = _maxHP._value;
	}
	
	void Update ()
	{
        CheckHealth();
	}

    public virtual void Damage(float damageAmount)
    {
        _HP -= damageAmount;
        _damageEvent.Invoke();
    }

    public void Heal(float healAmount)
    {
        _HP += healAmount;
        _healEvent.Invoke();
    }

    public float GetHealthPercentage()
    {
        return _HP / _maxHP._value;
    }

    private void CheckHealth()
    {
        if (_HP > _maxHP._value)
        {
            _HP = _maxHP._value;
        }

        if (_HP <= 0.0f)
        {
            _deathEvent.Invoke();
            Destroy(gameObject);
        }
    }
}
