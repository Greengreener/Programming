using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean Code: CTRL + K + D (in that order)

    // {} - Braces
    // [] - Brackets
    // () - Parentesis

public class Moving : MonoBehaviour
{
    public float rotationSpeed = 360;
    public float movementSpeed = 10;
    public float movementSpeedback = 5;

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
                }

        if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.Translate(Vector3.down * movementSpeedback * Time.deltaTime);
                }

     
    }

    void Rotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
                }

        if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
                }
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }
}
