using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        gameObject.SetActive(false);
        BallReset.GameStart.Invoke();
    }


    
}
