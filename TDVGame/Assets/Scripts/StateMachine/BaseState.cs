public abstract class BaseState
{
    protected IStateSwitcher IStateSwitcher;

    public BaseState (IStateSwitcher iStateSwitcher)
    {
        IStateSwitcher = iStateSwitcher;
    }

    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
    public abstract void CheckSwitchState();
}
