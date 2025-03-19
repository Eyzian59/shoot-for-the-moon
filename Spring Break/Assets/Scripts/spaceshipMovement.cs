using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipMovement : MonoBehaviour
{
    public float thrustSpeed = 5f;
    public float tiltSpeed = 50f;
    private bool isThrusting = false;
    private float currentTilt = 0f;

    // Update is called once per frame
    void Update()
    {
        handleThrust();
        if (isThrusting)
        {
            handleTilt();
        }
    }

    void handleThrust()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isThrusting)
        {
            isThrusting = true;
        }
        if (isThrusting)
        {
            transform.Translate(Vector3.up * thrustSpeed * Time.deltaTime);
        }
    }

    void handleTilt()
    {
        float tiltInput = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            tiltInput = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tiltInput = -1f;
        }
        currentTilt += tiltInput * tiltSpeed * Time.deltaTime;
        currentTilt = Mathf.Clamp(currentTilt, -45f, 45f);
        transform.rotation = Quaternion.Euler(0f, 0f, currentTilt);
    }
}
