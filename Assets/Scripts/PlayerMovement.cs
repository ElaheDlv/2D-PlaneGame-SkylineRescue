using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   

    public float moveSpeed = 5f; // Speed of the plane
    public float verticalSpeed = 5f; // Speed of vertical movement
    public float maxY = 3.5f; // Maximum Y position to clamp
    public float minY = -3.5f; // Minimum Y position to clamp

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get player input for vertical movement (up/down arrow or W/S keys)
        float verticalMove = Input.GetAxis("Vertical");

        // Move the plane vertically
        Vector3 movement = new Vector3(0, verticalMove * verticalSpeed * Time.deltaTime, 0);
        transform.Translate(movement);

        // Clamp the movement to keep the plane within the screen bounds
        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, minY, maxY);
        transform.position = clampedPosition;

        // Move the plane forward automatically (if needed)
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
