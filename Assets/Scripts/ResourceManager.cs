using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public GameObject cubePrefab;
    
    void Start()
    {
        //Instantiate(cubePrefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));

        LoadResources();
    }

    void LoadResources()
    {
        Instantiate(Resources.Load<GameObject>("Cube"), new Vector3(0,0,0), new Quaternion(0,0,0,0));
        //resources폴더 아래의 경로를 적어줌
    }

}
