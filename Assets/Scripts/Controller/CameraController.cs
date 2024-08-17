using UnityEngine;

public class CameraController
{
    private CameraInput _input;

    public CameraController()
    {
        _input = new();
    }

    public Vector2 GetMovement()
    {
        return _input.Game.Moving.ReadValue<Vector2>();
    }
}
