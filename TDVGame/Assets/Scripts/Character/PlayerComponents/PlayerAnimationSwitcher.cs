using UnityEngine;

public class PlayerAnimationSwitcher : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    public Animator Animator { get => _animator; }

    private int _idelHash;
    private int _walkHash;
    private int _runHash;

    public int IdelHash { get => _idelHash; }
    public int WalkHash { get => _walkHash; }
    public int RunHash { get => _runHash; }

    private void Awake()
    {
        _idelHash = Animator.StringToHash("Idel");
        _walkHash = Animator.StringToHash("Walk");
        _runHash = Animator.StringToHash("Run");
    }

    public void SetBoolParametersByHash(int hash, bool value)
    {
        _animator.SetBool(hash, value);
    }
    
    public void SetBoolParameters(string parameter, bool value)
    {
        _animator.SetBool(parameter, value);
    }
}
