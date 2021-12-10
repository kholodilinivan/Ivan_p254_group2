using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromScreenToWorld : MonoBehaviour
{
    public GameObject newobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate a prefab on the scene in the place of the mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            print(Input.mousePosition);
            Vector3 pos = Input.mousePosition;
            pos.z = 10f;
            pos = Camera.main.ScreenToWorldPoint(pos);
            Instantiate(newobject, pos, Quaternion.identity);
        }
    }
}
