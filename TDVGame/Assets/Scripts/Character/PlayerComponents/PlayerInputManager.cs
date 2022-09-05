using UnityEngine;

public class PlayerInputManager : PlayerComponent
{
    [SerializeField]
    private KeyCode _runButton;

    [SerializeField]
    private KeyCode _attackButton;

    private void Start()
    {
        Application.targetFrameRate = -1;
    }

    private void Update()
    {
        PlayerRoot.MoveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        PlayerRoot.MouseAxisInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        PlayerRoot.RunButtonIsPressed = Input.GetKey(_runButton);

        PlayerRoot.AttackButtonIsClicked = Input.GetKeyDown(_attackButton);
    }
}
