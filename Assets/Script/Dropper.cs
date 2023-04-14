using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float delayTimeToDrop = 3f;
    void Start()
    {
        
    }

    
    void Update()
    {
      if(Time.time > delayTimeToDrop)
      {
        GetComponent<Rigidbody>().useGravity = true;
      }
        
    }

   
}
