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

    void Start()
    {
        _ballRB = B.GetComponent<Rigidbody2D>();
        _turn = false;
        B.transform.position = _ballPostion;
        B.SetActive(false);
        GoalScored = new UnityEvent();
        GameStart = new UnityEvent();
        GoalScored.AddListener(ResetB);
        GameStart.AddListener(SpawnB);
        //B.transform.position = _ballPostion;
        //B.SetActive(false);


    }

    public void ResetB()
    {
        B.SetActive(false);
        Debug.Log("i");
        if (_turn == false)
        {
            B.transform.position = _ballPostion;
            B.SetActive(true);
            _ballRB.AddForce(new Vector2(20, 15));
            _turn = true;
            Debug.Log("j");
        }
        else if (_turn == true)
        {
            B.transform.position = _ballPostion;
            B.SetActive(true);
            _ballRB.AddForce(new Vector2(20, -15));
            _turn = false;
            Debug.Log("l");
        }


    }
    public void SpawnB()
    {
        B.transform.position = _ballPostion;
        B.SetActive(true);
        _ballRB.AddForce(new Vector2(20, 15));
        _turn = true;
        Debug.Log("T");
    }

}
