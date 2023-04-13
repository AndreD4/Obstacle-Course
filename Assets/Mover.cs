using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0.1f;
    float yValue = 0f;
    float zValue = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(xValue, yValue,zValue);
    }
}
