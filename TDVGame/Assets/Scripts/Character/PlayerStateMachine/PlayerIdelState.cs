public class PlayerIdelState : PlayerMoveableState
{
    public PlayerIdelState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(playerRootComponent, iStateSwitcher)
    {
        
    }

    public override void Enter()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.IdelHash, true);
    }

    public override void Update()
    {
        base.Update();
        CheckSwitchState();
    }

    public override void Exit()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.IdelHash, false);
    }

    public override void CheckSwitchState()
    {
        if (PlayerRoot.MoveInput.magnitude > 0)
        {
            IStateSwitcher.SwitchState<PlayerWalkState>();
        }
        if (PlayerRoot.AttackButtonIsClicked)
        {
            IStateSwitcher.SwitchState<PlayerAttackingState>();
        }
    }
}
