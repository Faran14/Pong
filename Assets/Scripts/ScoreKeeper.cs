using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]private float _scoreP1;
    [SerializeField]private float _scoreP2;
    //public GameObject GoalTop;
    //public GameObject TopBottom;
    public static UnityEvent GoalScoredTop;
    public static UnityEvent GoalScoredBottom;
    public static UnityEvent ResetScore;
    public TMP_Text P1S;
    public TMP_Text P2S;


    private void Start()
    {
        _scoreP1 = 0;
        _scoreP2 = 0;
        GoalScoredTop = new UnityEvent();
        GoalScoredBottom = new UnityEvent();
        ResetScore = new UnityEvent();
        GoalScoredTop.AddListener(UpdateScoreTop);
        GoalScoredBottom.AddListener(UpdateScoreBottom);
        ResetScore.AddListener(SReset);
    }
    
    private void UpdateScoreTop()
    {
        _scoreP1 += 1;
        P1S.text = _scoreP1.ToString();
        if (_scoreP1>=10)
        {
        //Debug.Log("Top");
            GameloopManager.P1Won.Invoke(); }    
    }
    private void UpdateScoreBottom()
    {
        _scoreP2 += 1;
        P2S.text = _scoreP2.ToString();
        if (_scoreP2 >= 10)
        { GameloopManager.P2Won.Invoke(); }
        //Debug.Log("Bottom");
    }
    private void SReset()
    {
        _scoreP1 = 0;
        P1S.text = _scoreP1.ToString();
        _scoreP2 = 0;
        P2S.text = _scoreP2.ToString();
    }
}
