using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Transform CamTransform; // transformations params of the cam
    public float shakeTime; // how long we want to shake our cam
    public float shakeRange; // how far we want to shake our camera
    Vector3 originalPos; // initial cam pos

    // Start is called before the first frame update
    void Start()
    {
        CamTransform = Camera.main.transform;
        originalPos = CamTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShakeCamera()); // StartCoroutine("ShakeCamera");
        }
    }

    IEnumerator ShakeCamera()
    {
        float elapsedTime = 0;
        while(elapsedTime < shakeTime)
        {
            CamTransform.position = Random.insideUnitSphere* shakeRange;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        CamTransform.position = originalPos;
    }
}
