using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsWork : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate the �Sphere� by clicking left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sphere, transform.position, Quaternion.identity);
        }
    }
}
