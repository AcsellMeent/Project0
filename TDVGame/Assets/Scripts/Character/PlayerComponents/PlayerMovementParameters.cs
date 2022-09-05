using UnityEngine;

public class PlayerMovementParameters : PlayerComponent
{
    [SerializeField]
    private Rigidbody _rigidbody;
    public Rigidbody Rigidbody { get => _rigidbody; }

    [SerializeField]
    private float _walkSpeed;

    public float WalkSpeed { get => _walkSpeed; }


    [SerializeField]
    private float _runSpeed;

    public float RunSpeed { get => _runSpeed; }

}
