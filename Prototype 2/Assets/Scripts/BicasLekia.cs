using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicasLekia : MonoBehaviour
{
    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
