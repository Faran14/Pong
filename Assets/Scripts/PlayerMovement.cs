using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using System;

public class PlayerMovement : Movement
{

    private Vector3 _position;
    

   
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        _Movement.x = -InputController.Input.x;
        _Movement.y = 0;
        _Paddle.velocity = _Movement * _Speed;

        var clampX = Math.Clamp(transform.position.x, _LeftClampPos, _RightClampPos);
        _position = transform.position;
        _position.x = clampX;
        transform.position = _position;
    }
}
