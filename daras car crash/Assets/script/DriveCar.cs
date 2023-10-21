using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _fronttireRB;
    [SerializeField] private Rigidbody2D _backtireRB;
    [SerializeField] private float _speed = 150f;

    private float _moveInput;

    private void Update()
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _fronttireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backtireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
    }
}
