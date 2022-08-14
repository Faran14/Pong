using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartScreen : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject RetryButton;
    public GameObject Paddle;
    public TMP_Text P1Win;
    public TMP_Text P2Win;
    // Start is called before the first frame update
    public void GameStart()
    {
        StartButton.SetActive(false);
        Paddle.SetActive(true);
        BallReset.GameStart.Invoke();
    }

    public void Retry()
    {
        P1Win.gameObject.SetActive(false);
        P2Win.gameObject.SetActive(false);
        ScoreKeeper.ResetScore.Invoke();
        RetryButton.SetActive(false);
        BallReset.GameStart.Invoke();
    }
    
}
