using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore
{
    public int score;
    public int result;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            // if 5 < Score < 10
            if(value > 5 && value < 10)
            {
                score = value;
            }
        }
    }

    public int Result { get; set; }
}
