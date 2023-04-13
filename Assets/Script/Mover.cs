using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
        PrintInstruction();
    }

    
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
      Debug.Log("WASD TO MOVE");
      Debug.Log ("Avoid the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
