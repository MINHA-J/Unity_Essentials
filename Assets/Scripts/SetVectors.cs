using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVectors : MonoBehaviour
{
    public GameObject sphere;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //SetVector();
        //ShowCoordinate();
        SetSpherePos();
    }

    public void SetVector()
    {
        Vector2 vec2 = new Vector2(1, 0);
        Vector3 vec3_1 = new Vector3(3, 4, 5);
        Vector3 vec3_2 = new Vector3(1, 1, 1);

        Debug.DrawLine(new Vector3(0, 0, 0), vec2, Color.blue, 30.0f, false);

        Debug.DrawLine(new Vector3(0, 0, 0), vec3_1, Color.magenta, 30.0f, false);
        Debug.DrawLine(new Vector3(0, 0, 0), vec3_2, Color.magenta, 30.0f, false);
        Debug.DrawLine(new Vector3(0, 0, 0), vec3_1 - vec3_2, Color.red, 30.0f, false);
        //Debug.DrawLine(vec3_1, vec3_2, Color.gray, 30.0f, false);
    }

    public void ShowCoordinate()
    {
        Debug.DrawLine(new Vector3(0, 0, 0), Vector3.right, Color.red, 30.0f, false);
        Debug.DrawLine(new Vector3(0, 0, 0), Vector3.up, Color.green, 30.0f, false);
        Debug.DrawLine(new Vector3(0, 0, 0), Vector3.forward, Color.blue, 30.0f, false);

    }

    public void SetSpherePos()
    {
        sphere.SetActive(true);
        sphere.transform.position = new Vector3(3, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
