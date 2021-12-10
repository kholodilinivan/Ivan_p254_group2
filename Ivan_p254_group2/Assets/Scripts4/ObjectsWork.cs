using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.speed = 6.6f;
        myVehicle.color = "White";

        Vehicle newVehicle = new Vehicle();
        newVehicle.speed = 12f;
        newVehicle.color = "Black";

        myVehicle.VehicleSpeed();
        myVehicle.VehicleColor();

        newVehicle.VehicleSpeed();
        newVehicle.VehicleColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
