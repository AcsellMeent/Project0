using UnityEngine;
public abstract class PlayerState : BaseState
{
    public PlayerRootComponent PlayerRoot;

    protected PlayerMovementParameters MovementParameters;
    protected PlayerAnimationSwitcher AnimationSwitcher;
    protected PlayerAnimationEvents AnimationEvents;
    public PlayerState(PlayerRootComponent playerRootComponent, IStateSwitcher iStateSwitcher) : base(iStateSwitcher)
    {
        PlayerRoot = playerRootComponent;
        MovementParameters = PlayerRoot.PlayerMovementParameters;
        AnimationSwitcher = PlayerRoot.PlayerAnimationSwitcher;
        AnimationEvents = PlayerRoot.PlayerAnimationEvents;
    }
}
