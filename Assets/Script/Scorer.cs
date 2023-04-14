using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
      Debug.Log("You've bumped into a thing this many times:");
    }
}
