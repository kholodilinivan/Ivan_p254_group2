using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesWork : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneChangerName();
        }

        if (Input.GetMouseButtonDown(1))
        {
            SceneChangerIndex();
        }

        if (Input.GetMouseButtonDown(2))
        {
            SceneChangerPublicIndex();
        }
    }

    void SceneChangerName()
    {
        SceneManager.LoadScene("level2");
        print("scene opened by name");
    }

    void SceneChangerIndex()
    {
        SceneManager.LoadScene(1);
        print("scene opened by index");
    }

    void SceneChangerPublicIndex()
    {
        SceneManager.LoadScene(index);
        print("scene opened by public index");
    }
}
