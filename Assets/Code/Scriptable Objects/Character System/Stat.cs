using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Character System/Stat")]
public class Stat : ScriptableObject
{
    public Attribute attribute;
    public int value;
}
