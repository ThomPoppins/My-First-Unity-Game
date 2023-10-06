using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalBoundary = 8.0f; // Horizontal boundaries
    private float speed = 20.0f; // Player speed
    private Rigidbody playerRb; // Player rigidbody

    // Start is called before the first frame update
    void Start()
    {
        // Get player rigidbody
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move player left and right with arrow keys or A and D within the left and right boundaries from the input manager
        if (Input.GetAxis("Horizontal") > 0 && transform.position.x < horizontalBoundary)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0 && transform.position.x > -horizontalBoundary)
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        }
    }
}
