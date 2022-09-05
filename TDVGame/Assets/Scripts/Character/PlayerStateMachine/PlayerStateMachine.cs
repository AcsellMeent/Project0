using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class PlayerStateMachine : PlayerComponent, IStateSwitcher
{
    private PlayerState _currentState;
    public List<PlayerState> _allPlayerStates;

    [SerializeField]
    private bool _logState;

    private void Start()
    {
        _allPlayerStates = new List<PlayerState>
        {
            new PlayerIdelState(PlayerRoot, this),
            new PlayerWalkState(PlayerRoot, this),
            new PlayerRunState(PlayerRoot, this),
            new PlayerAttackingState(PlayerRoot, this),
        };

        _currentState = _allPlayerStates[0];
        _currentState.Enter();
    }

    private void Update()
    {
        _currentState.Update();
    }

    public void SwitchState<T>() where T : BaseState
    {
        var newState = _allPlayerStates.FirstOrDefault(s => s is T);
        _currentState.Exit();
        if (_logState)
        {
            Debug.Log($"Switch from <color=red>{_currentState.ToString()}</color> to <color=green>{newState.ToString()}</color>");
        }
        newState.Enter();
        _currentState = newState;
    }
}
