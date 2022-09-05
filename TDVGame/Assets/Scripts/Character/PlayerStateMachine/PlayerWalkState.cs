public class PlayerWalkState : PlayerMoveableState
{
    public PlayerWalkState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(playerRootComponent, iStateSwitcher) { }

    public override void Enter()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.WalkHash, true);
        MoveSpeed = MovementParameters.WalkSpeed;
    }

    public override void Exit()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.WalkHash, false);
    }

    public override void Update()
    {
        base.Update();
        CheckSwitchState();
    }

    public override void CheckSwitchState()
    {
        if(PlayerRoot.MoveInput.magnitude == 0)
        {
            IStateSwitcher.SwitchState<PlayerIdelState>();
        }
        if(PlayerRoot.RunButtonIsPressed)
        {
            IStateSwitcher.SwitchState<PlayerRunState>();
        }
        if(PlayerRoot.AttackButtonIsClicked)
        {
            IStateSwitcher.SwitchState<PlayerAttackingState>();
        }
    }
}
