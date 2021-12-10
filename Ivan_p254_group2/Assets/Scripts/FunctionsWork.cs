using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWork : MonoBehaviour
{
    int a = 7;
    // Start is called before the first frame update
    void Start()
    {
        int a1 = doubleval();
        print(a1);

        int val1 = sumval(5);
        print(val1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int doubleval()
    {
        return (a * 2);
    }

    int sumval(int val)
    {
        return (val + 10);
    }
}
