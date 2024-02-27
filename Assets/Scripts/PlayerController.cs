using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerMovement")]

    float horizontalInput;

    [SerializeField] float speed = 10;

    [Header("PlayerPosition")]

    //Variable that sees the max range the player can go to
    [SerializeField] float xRange = 10;

    void Update()
    {
        Movement();

        FixPosition();
    }

    //Code that moves the player
    void Movement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    //Code that fixes the player position if he gets out of camera
    void FixPosition()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }

}
