using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallReset : MonoBehaviour
{
    private bool _turn;
    public GameObject B;
    private Rigidbody2D _ballRB;
    private Vector2 _ballPostion = new Vector2(0, 0);
    //false is player 1
    //ture is player 2
    public static UnityEvent GoalScored;
    public static UnityEvent GameStart;
    public static UnityEvent EndGame;
    private float _x;
    private float _y;
    private float _xDirection;
    [SerializeField] private float _speed;

    void Start()
    {
        _ballRB = B.GetComponent<Rigidbody2D>();
        _turn = false;
        B.transform.position = _ballPostion;
        B.SetActive(false);
        GoalScored = new UnityEvent();
        GameStart = new UnityEvent();
        EndGame = new UnityEvent();
        GoalScored.AddListener(ResetB);
        GameStart.AddListener(SpawnB);
        EndGame.AddListener(DisableBall);
        _speed = 10;
        //B.transform.position = _ballPostion;
        //B.SetActive(false);


    }

    public void ResetB()
    {
        B.SetActive(false);
        //Debug.Log("i");
        //_x = Random.Range(.5f, 2f);
        //_y = Random.Range(1f, 2f);
        //_xDirection = Random.Range(0, 1);

        //if (_xDirection==0)
        //{
        //    _x = -_x;
        //}
        BallDirction();

        if (_turn == false)
        {
            B.transform.position = _ballPostion;
            B.SetActive(true);
            _ballRB.AddForce(new Vector2(_x, _y)* _speed);
            _turn = true;
            //Debug.Log("j");
        }
        else if (_turn == true)
        {
            B.transform.position = _ballPostion;
            B.SetActive(true);
            _ballRB.AddForce(new Vector2(_x, -_y)* _speed);
            _turn = false;
            //Debug.Log("l");
        }


    }
    public void SpawnB()
    {
        BallDirction();
        B.transform.position = _ballPostion;
        B.SetActive(true);
        _ballRB.AddForce(new Vector2(_x, _y)* _speed);
        _turn = true;
        //Debug.Log("T");
    }

    private void BallDirction()
    {
        _x = Random.Range(.5f, 2f);
        _y = Random.Range(1f, 2f);
        _xDirection = Random.Range(0f, 1f);

        if (_xDirection <0.5f)
        {
            _x = -_x;
        }
    }

    private void DisableBall()
    {
        B.SetActive(false);
    }

}
