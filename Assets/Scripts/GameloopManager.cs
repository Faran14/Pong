using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;
public class GameloopManager : MonoBehaviour
{
    public static UnityEvent P1Won;
    public static UnityEvent P2Won;
    public GameObject RetryButton;
    public TMP_Text P1Win;
    public TMP_Text P2Win;

   
    void Start()
    {
        RetryButton.SetActive(false);
        P1Won = new UnityEvent();
        P2Won = new UnityEvent();
        P1Won.AddListener(DisplayVictory_P1);
        P2Won.AddListener(DisplayVictory_P2);

    }

   
    private void DisplayVictory_P1()
    {
        //Debug.Log("Text1");
        BallReset.EndGame.Invoke();
        P1Win.gameObject.SetActive(true);
        
        RetryButton.SetActive(true);
    }
    private void DisplayVictory_P2()
    {
        BallReset.EndGame.Invoke();
        P2Win.gameObject.SetActive(true);
        RetryButton.SetActive(true);
    }
}
