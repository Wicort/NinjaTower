using System;

public interface IInput 
{
    public event Action onJump;
    public event Action onCrouch;
    public event Action<float> onMove;
}
