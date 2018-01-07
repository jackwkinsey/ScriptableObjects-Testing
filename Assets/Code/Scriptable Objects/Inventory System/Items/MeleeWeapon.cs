using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipment/Weapons/Melee Weapon")]
public class MeleeWeapon : EquippableItem
{
    public float range = 1f;
    public float damage = 1f;
}
