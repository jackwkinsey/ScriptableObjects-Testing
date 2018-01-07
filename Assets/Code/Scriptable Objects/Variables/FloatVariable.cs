using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Float", order = 0)]
public class FloatVariable : ScriptableObject
{
    #if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
    #endif

    public float _value;

    public void SetValue(float value)
    {
        _value = value;
    }

    public void SetValue(FloatVariable value)
    {
        _value = value._value;
    }

    public void ApplyChange(float amount)
    {
        _value += amount;
    }

    public void ApplyChange(FloatVariable amount)
    {
        _value += amount._value;
    }
}
