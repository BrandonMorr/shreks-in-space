using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly : MonoBehaviour
{
    public float playerSpeed;

    void Update()
    {
        // We move the player with the second touch input
        if (Input.touchCount > 1 || Input.GetMouseButton(0))
        {
            transform.position = transform.position + (Camera.main.transform.forward * playerSpeed * Time.deltaTime);
        }
    }
}
