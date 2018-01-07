using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageArea : MonoBehaviour
{
    private float _damage;
    private float _lifetime = 0.1f;

    public float Damage
    {
        get
        {
            return _damage;
        }

        set
        {
            _damage = value;
        }
    }

    private void Start()
    {
        Destroy(gameObject, _lifetime);
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision!");
        UnitHealth health = other.gameObject.GetComponent<UnitHealth>();

        if (health != null)
        {
            health.TakeDamage(_damage);
        }
    }
}
