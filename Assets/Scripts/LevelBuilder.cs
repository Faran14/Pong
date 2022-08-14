using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    
    public static float _width;
    public GameObject WallRight;
    public GameObject WallLeft;
    public GameObject GoalTop;
    public GameObject GoalBottom;
    public GameObject PlayerPaddle;
    public GameObject AIPaddle;
    // Start is called before the first frame update
    
    private void Start()
    {
        GetAspectRatio();
        WallSpawner();
        GoalSpawner();
        P1Spawner();
        P2Spawner();

    }

    private void GetAspectRatio()
    {
        _width = Camera.main.aspect * 10;
        Debug.Log(_width);
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
        GoalTop.transform.localScale = new Vector2(_width, 0.05f);
        GoalBottom.transform.position = new Vector2(0, -5);
        GoalBottom.transform.localScale = new Vector2(_width, 0.05f);
    }

    private void P1Spawner()
    {
        PlayerPaddle.transform.position = new Vector2(0, -4.9f);
        PlayerPaddle.transform.localScale = new Vector2(_width/3,0.25f);
    }
    private void P2Spawner()
    {
        AIPaddle.transform.position = new Vector2(0, 4.9f);
        AIPaddle.transform.localScale = new Vector2(_width / 3, 0.25f);
    }


}
