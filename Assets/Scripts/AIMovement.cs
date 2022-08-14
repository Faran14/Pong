using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AIMovement : Movement
{
    public GameObject Ball;
    private Vector3 _position;
    private void Update()
    {
        Move();
    }

    public override void Move()
    {
        _Movement.x = Ball.transform.position.x;
        _Movement.y = 0;
        _Paddle.velocity =  _Movement * 2;
        var clampX = Math.Clamp(transform.position.x, _LeftClampPos, _RightClampPos);
        _position = transform.position;
        _position.x = clampX;
        transform.position = _position;
    }

}
