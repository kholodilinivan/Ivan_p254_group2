using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vehicle myVehicle2 = new Vehicle();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Vehicle myVehicle2 = new Vehicle(70f);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Vehicle myVehicle2 = new Vehicle(7.8f, "Yellow");
        }
    }
}
