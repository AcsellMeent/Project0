using UnityEngine;

public abstract class PlayerMoveableState : PlayerState
{
    protected PlayerMoveableState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(playerRootComponent, iStateSwitcher)
    {
        _playerModelAxis = PlayerRoot.PlayerModelAxis;
        _desiredDiraction = _playerModelAxis.forward;
    }         

    private Vector3 _desiredDiraction;

    private Transform _playerModelAxis;

    protected float MoveSpeed;

    const float MovePositionRatio = 0.01f;

    public override void Update()
    {
        FindMoveDiraction();
        Move();
    }

    public void FindMoveDiraction()
    {
        if (PlayerRoot.MoveInput.magnitude > 0)
        {
            _desiredDiraction = Vector3.ClampMagnitude
                (PlayerRoot.transform.right * PlayerRoot.MoveInput.x + PlayerRoot.MoveInput.y * PlayerRoot.transform.forward, 1);
        }
        float cosAngle = Mathf.Acos(_desiredDiraction.z) * 180 / Mathf.PI;
        float finalAngle = _desiredDiraction.x > 0 ? cosAngle : 360 - cosAngle;

        Quaternion quaternionAngle = Quaternion.Euler(new Vector3(0, finalAngle, 0));
        _playerModelAxis.rotation = Quaternion.Lerp(_playerModelAxis.rotation, quaternionAngle, 0.1f);
    }

    public void Move()
    {
        float speedRatio = Vector3.Dot(_playerModelAxis.forward,_desiredDiraction);

        MovementParameters.Rigidbody.MovePosition(PlayerRoot.transform.position + (_playerModelAxis.forward * MovePositionRatio * MoveSpeed * speedRatio));
    }
}
