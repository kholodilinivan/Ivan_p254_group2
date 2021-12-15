using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarProperties : MonoBehaviour
{
    public int newScore;
    public int newResult;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TotalScore totalScore = new TotalScore();
            totalScore.Score = newScore;
            print(totalScore.Score);
        }

        if (Input.GetMouseButtonDown(1))
        {
            TotalScore totalScore = new TotalScore();
            totalScore.Result = newResult;
            print(totalScore.Result);
        }
    }
}
