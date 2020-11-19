using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float moveSpeed, turnSpeed;

    private Vector2 moveInput;

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * moveInput.y);
        transform.Rotate(Vector3.up, turnSpeed * moveInput.x * Time.deltaTime);
    }
}
