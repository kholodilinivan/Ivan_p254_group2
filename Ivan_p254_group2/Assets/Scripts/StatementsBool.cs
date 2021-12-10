using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsBool : MonoBehaviour
{
    public bool student;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!student) // (student == false)
        {
            print("try again");
        }
        else
        {
            print("passed");
        }
    }
}
