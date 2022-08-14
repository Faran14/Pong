using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    protected Rigidbody2D _Paddle;
    [SerializeField] protected float _Speed;
    protected Vector2 _Movement;
    protected float _LeftClampPos;
    protected float _RightClampPos;
    private void OnEnable()
    {
        _Paddle = GetComponent<Rigidbody2D>();
        _Speed = 10f;
    }

    private void Start()
    {
        _LeftClampPos = -(LevelBuilder._width/2) + (transform.localScale.x / 1.5f);
        _RightClampPos = (LevelBuilder._width/2) - (transform.localScale.x / 1.5f);
        Debug.Log(_LeftClampPos);
        Debug.Log(_RightClampPos);
    }
    public abstract void Move();

}
