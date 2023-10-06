using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Rotationscript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("update"+Time.deltaTime);
        //transform.Rotate(new Vector3(Rotationscript,0,0),Space.World);
        transform.Rotate(new Vector3(0, Rotationscript, 0), Space.World);

    }
}
