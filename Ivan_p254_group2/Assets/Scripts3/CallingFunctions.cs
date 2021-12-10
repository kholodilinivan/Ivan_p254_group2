using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingFunctions : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the Game Object once, with the use of function �Invoke�
        // Invoke("BallCreation", 2f);

        // Instantiate the Game Object repeatedely, with the use of function �InvokeRepeating�
        InvokeRepeating("BallCreation", 3f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
            // Stop instantiating process of �InvokeRepeating� with �CancelInvoke� by clicking the wheel mouse button
            CancelInvoke("BallCreation");
        }
    }

    void BallCreation()
    {
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
