using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Transform position of Game Objectto the up direction by defining new Vector3 and by up arrow keyboard button
        // transform.position = transform.position + new Vector3(0, 0.01f, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f, 0);
        }

        // Transform position of Game Object to the left by defining function “transform.right” and by left arrow keyboard button

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right*speed;
        }

        // Move Game Object to the right by defining function “transform.Translate” and by right arrow keyboard button

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed,0,0);
        }

        // Rotate the Game Object by “transform.Rotate” and change it scale by “transform.localScale” and defining new Vector3 and by down arrow keyboard button
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(speed, speed, 0);
            transform.localScale += new Vector3(0, speed, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("pressed Space");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("released Space");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("hold Space");
        }
    }
}
