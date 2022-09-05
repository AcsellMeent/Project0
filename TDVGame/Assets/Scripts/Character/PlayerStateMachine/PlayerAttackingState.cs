using UnityEngine;

public class PlayerAttackingState : PlayerState
{
    public PlayerAttackingState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(playerRootComponent, iStateSwitcher)
    {
        _playerAttackParameters = playerRootComponent.PlayerAttackParameters;
    }

    private PlayerAttackParameters _playerAttackParameters;

    private bool _canAttackSwitch;
    private bool _attackSwitch;

    private int _currentAttackIndex;

    private int _maxAttackIndex;

    public override void Enter()
    {
        AnimationEvents.OnAttackEnd += EndAttack;
        AnimationEvents.OnCanSwitchAttack += SetCanSwitchAttack;
        AnimationSwitcher.SetBoolParameters(_playerAttackParameters.AttackParameters[0].AnimationParameter, true);
        _maxAttackIndex = _playerAttackParameters.AttackParameters.Length;
    }

    public override void Exit()
    {
        AnimationSwitcher.SetBoolParameters(_playerAttackParameters.AttackParameters[_currentAttackIndex].AnimationParameter, false);
        _currentAttackIndex = 0;
        AnimationEvents.OnAttackEnd -= EndAttack;
        AnimationEvents.OnCanSwitchAttack -= SetCanSwitchAttack;
    }

    public override void Update()
    {
        if (_canAttackSwitch && PlayerRoot.AttackButtonIsClicked && _currentAttackIndex + 1 < _maxAttackIndex)
        {
            _canAttackSwitch = false;
            _attackSwitch = true;
            _currentAttackIndex++;
        }
    }

    public override void CheckSwitchState()
    {
    }

    private void EndAttack()
    {
        if (_attackSwitch)
        {
            _attackSwitch = false;
            AnimationSwitcher.SetBoolParameters(_playerAttackParameters.AttackParameters[_currentAttackIndex - 1].AnimationParameter, false);
            AnimationSwitcher.SetBoolParameters(_playerAttackParameters.AttackParameters[_currentAttackIndex].AnimationParameter, true);
        }
        else
        {
            IStateSwitcher.SwitchState<PlayerIdelState>();
        }
    }

    private void SetCanSwitchAttack()
    {
        _canAttackSwitch = true;
    }
}
