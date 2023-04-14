using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{   
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float delayTimeToDrop = 3f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    
    void Update()
    {
      if(Time.time > delayTimeToDrop)
      {
        renderer.enabled = true;
        rigidbody.useGravity = true;

      }
        
    }

   
}
