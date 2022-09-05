using UnityEngine;
using System;

public class PlayerAttackParameters : PlayerComponent
{
    [SerializeField]
    private AttackParameters[] _attackParameters;

    public AttackParameters[] AttackParameters { get => _attackParameters; }
}

[Serializable]
public class AttackParameters
{
    [SerializeField]
    private string _animationParameter;

    public string AnimationParameter { get => _animationParameter; }

    
    [SerializeField]
    private float _pushForce;

    public float PushForce { get => _pushForce; }
}