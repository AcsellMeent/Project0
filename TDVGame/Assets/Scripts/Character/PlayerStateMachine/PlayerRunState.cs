using UnityEngine;

public class PlayerRunState : PlayerMoveableState
{
    public PlayerRunState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(playerRootComponent, iStateSwitcher) { }

    public override void Enter()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.RunHash, true);
        MoveSpeed = MovementParameters.RunSpeed;
    }

    public override void Exit()
    {
        AnimationSwitcher.SetBoolParametersByHash(AnimationSwitcher.RunHash, false);
    }

    public override void Update()
    {
        base.Update();
        CheckSwitchState();
    }

    public override void CheckSwitchState()
    {
        if (PlayerRoot.MoveInput.magnitude == 0)
        {
            IStateSwitcher.SwitchState<PlayerIdelState>();
        }
        if (!PlayerRoot.RunButtonIsPressed)
        {
            IStateSwitcher.SwitchState<PlayerWalkState>();
        }
        if(PlayerRoot.AttackButtonIsClicked)
        {
            IStateSwitcher.SwitchState<PlayerAttackingState>();
        }
    }
}
