using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float velocity = Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * velocity;
        float zValue = Input.GetAxis("Vertical") * velocity;
        transform.Translate(xValue, 0, zValue);
    }
}
