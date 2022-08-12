using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]private float _scoreP1;
    [SerializeField]private float _scoreP2;
    //public GameObject GoalTop;
    //public GameObject TopBottom;
    public static UnityEvent GoalScoredTop;
    public static UnityEvent GoalScoredBottom;


    private void Start()
    {
        _scoreP1 = 0;
        _scoreP2 = 0;
        GoalScoredTop = new UnityEvent();
        GoalScoredBottom = new UnityEvent(); 
        GoalScoredTop.AddListener(UpdateScoreTop);
        GoalScoredBottom.AddListener(UpdateScoreBottom);
    }

    private void UpdateScoreTop()
    {
        _scoreP1 += 1;
        //Debug.Log("Top");
    }
    private void UpdateScoreBottom()
    {
        _scoreP2 += 1;
        //Debug.Log("Bottom");
    }
}
