using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    [SerializeField]
    private Transform _damageArea;

    [SerializeField]
    private Stat _governingStat;

    [SerializeField]
    private Equipment _equipment;

    [SerializeField]
    private StatsList _statsList;

    private List<Stat> _stats;

    private float _damage;
    private float _range;

    private Vector2 _damagePoint;

    private void Start()
    {
        _stats = _statsList.value;
        _range = _equipment.meleeWeapon.range;
    }

    private void Update()
    {

    }

    public void Trigger(Vector2 direction)
    {
        CalculateDamage();

        // Instantiate damage area prefab based on direction and melee weapon range?
        // How I do that?
        _damagePoint = (Vector2)transform.position + (direction.normalized * _range);
        var damageArea = Instantiate(_damageArea, _damagePoint, transform.rotation).GetComponent<DamageArea>();
        damageArea.Damage = _damage;

        Physics2D.IgnoreCollision(damageArea.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
    }

    private void CalculateDamage()
    {
        var index = _stats.IndexOf(_governingStat);
        var stat = _stats[index];

        _damage = stat.value + _equipment.meleeWeapon.damage;
    }
}
