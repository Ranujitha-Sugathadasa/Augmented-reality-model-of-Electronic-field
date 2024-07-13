using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust this value to control rotation speed

    void Update()
    {
        // Get horizontal and vertical mouse movement
        float horizontalInput = Input.GetAxis("Mouse X");
        float verticalInput = Input.GetAxis("Mouse Y");

        // Rotate the object around its local X and Y axes
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * rotationSpeed);
        transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * rotationSpeed);
    }
}
