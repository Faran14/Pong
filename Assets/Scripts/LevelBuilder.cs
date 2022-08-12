using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    
    private float _width;
    public GameObject WallRight;
    public GameObject WallLeft;
    public GameObject GoalTop;
    public GameObject GoalBottom;
    // Start is called before the first frame update
    
    private void Start()
    {
        GetAspectRatio();
        WallSpawner();
        GoalSpawner();
    }

    private void GetAspectRatio()
    {
        _width = Camera.main.aspect * 10;
    }
    private void WallSpawner()
    {
        WallLeft.transform.position=new Vector2(-_width/2,0);
        WallLeft.transform.localScale = new Vector2(0.5f, 10);
        WallRight.transform.position = new Vector2(_width / 2, 0);
        WallRight.transform.localScale = new Vector2(0.5f, 10);
        
    }
    private void GoalSpawner()
    {
        GoalTop.transform.position = new Vector2(0, 5);
        GoalTop.transform.localScale = new Vector2(_width, 0.5f);
        GoalBottom.transform.position = new Vector2(0, -5);
        GoalBottom.transform.localScale = new Vector2(_width, 0.5f);
    }

}
