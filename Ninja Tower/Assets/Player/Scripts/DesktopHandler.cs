using System;
using UnityEngine;

public class DesktopHandler : MonoBehaviour, IInput
{
    public event Action onJump;
    public event Action onCrouch;
    public event Action<float> onMove;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0)
        {
            onMove?.Invoke(horizontal);
        }

        if (vertical > 0)
        {
            onJump?.Invoke();
        }

        if (vertical < 0)
        {
            onCrouch?.Invoke();
        }
    }
}
