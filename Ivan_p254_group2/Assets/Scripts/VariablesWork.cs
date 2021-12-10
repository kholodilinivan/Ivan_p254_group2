using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesWork : MonoBehaviour
{
    int number = 5;
    float position = 7.1f;
    char letter = 'c';
    public string name = "Ivan";
    // Start is called before the first frame update
    void Start()
    {
        print(number);
        print("position: " + position);
        print("letter: " + letter);
    }

    // Update is called once per frame
    void Update()
    {
        print("You're " + name);
    }
}
