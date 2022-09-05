using UnityEngine;

public class PlayerRootComponent : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementParameters _playerMovementParameters;
    public PlayerMovementParameters PlayerMovementParameters { get => _playerMovementParameters; }

    [SerializeField]
    private PlayerAttackParameters _playerAttackParameters;
    public PlayerAttackParameters PlayerAttackParameters { get => _playerAttackParameters; }

    [SerializeField]
    private PlayerAnimationSwitcher _playerAnimationSwitcher;
    public PlayerAnimationSwitcher PlayerAnimationSwitcher { get => _playerAnimationSwitcher; }

    [SerializeField]
    private PlayerAnimationEvents _playerAnimationEvents;
    public PlayerAnimationEvents PlayerAnimationEvents { get => _playerAnimationEvents; }

    [SerializeField]
    private Transform _playerModelAxis;

    public Transform PlayerModelAxis { get => _playerModelAxis; }

    public Vector2 MoveInput;
    public Vector2 MouseAxisInput;

    public bool RunButtonIsPressed;
    public bool AttackButtonIsClicked;
}
