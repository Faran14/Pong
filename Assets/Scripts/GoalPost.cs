using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalPost : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.transform.position.y>0)
        {
            //p1 scored
            ScoreKeeper.GoalScoredTop.Invoke();
            BallReset.GoalScored.Invoke();
        }
        if (gameObject.transform.position.y<0)
        {
            //p2 scored
            ScoreKeeper.GoalScoredBottom.Invoke();
            BallReset.GoalScored.Invoke();
        }

    }
}
