using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMoving : MonoBehaviour
{
    [Range(0, 10)]
    [SerializeField] private float _moveSpeed;

    [Range(0, 5)]
    [SerializeField] private float _jumpPower;

    private IInput _input;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _input = GetComponent<IInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _input.onMove += Move;
        _input.onJump += Jump;
    }

    private void Move(float value)
    {
        float speed = value * 100 * _moveSpeed * Time.deltaTime;
        Debug.Log(speed);
        _rigidbody.velocity = new Vector3(speed, _rigidbody.velocity.y, 0);
    }

    private void Jump()
    {

    }
}
