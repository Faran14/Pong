using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalPost : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.transform.position.y>0 && collision.tag=="Ball")
        {
            //p1 scored
            BallReset.GoalScored.Invoke();
            ScoreKeeper.GoalScoredTop.Invoke();
        }
        if (gameObject.transform.position.y<0 && collision.tag == "Ball")
        {
            //p2 scored
            BallReset.GoalScored.Invoke();
            ScoreKeeper.GoalScoredBottom.Invoke();
        }

    }
}
