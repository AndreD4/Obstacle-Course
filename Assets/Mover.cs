using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        
        transform.Translate(xValue,0,zValue);
    }
}
