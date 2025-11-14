using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f; // Determines the speed of the object's lateral movement or turning.
    private float horizontalInput; // Stores the input value for the horizontal axis (Left/Right keys).
    private float verticalInput; // Stores the input value for the vertical axis (Up/Down keys).
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get and store the input values for the horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");

        // Get and store the input values for the vertical axis
        verticalInput = Input.GetAxis("Vertical");

        // Mover el vehiculo hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Applies lateral movement to the vehicle.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
