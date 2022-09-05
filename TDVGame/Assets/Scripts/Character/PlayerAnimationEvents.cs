using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimationEvents : MonoBehaviour
{
    public UnityAction OnAttackEnd;
    public UnityAction OnCanSwitchAttack;

    // [SerializeField]
    // private ParticleSystem _slash;

    // [SerializeField]
    // private ParticleSystem _slash1;

    // public void StartAttack()
    // {
    //     _slash.Play();
    // }
    // public void StartAttack1()
    // {
    //     _slash1.Play();
    // }
    public void AttackEnd()
    {
        OnAttackEnd?.Invoke();
    }

    public void CanSwitchAttack()
    {
        OnCanSwitchAttack?.Invoke();
    }
}
