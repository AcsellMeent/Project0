using UnityEngine;

public abstract class PlayerComponent : MonoBehaviour
{
    protected PlayerRootComponent PlayerRoot;

    private void Awake()
    {
        PlayerRoot = GetComponent<PlayerRootComponent>();
    }
}
