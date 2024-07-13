using UnityEngine;

public class rotateAndZoomTouch1 : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Adjust rotation speed
    public float zoomSpeed = 5.0f;       // Adjust zoom speed
    private Vector2 startTouchPosition;   // Store starting touch position

    void Update()
    {
        // Handle touches
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // Rotation (based on touch drag)
                Vector2 delta = touch.position - startTouchPosition;
                transform.Rotate(Vector3.up, delta.x * rotationSpeed * Time.deltaTime);

                startTouchPosition = touch.position; // Update for next touch movement
            }
        }

        // Zoom (using pinch gesture)
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            // Calculate pinch distance change
            float startDistance = Vector2.Distance(touch1.position, touch2.position);
            float currentDistance = Vector2.Distance(touch1.position, touch2.position);
            float pinchAmount = currentDistance - startDistance;

            // Zoom in/out based on pinch direction
            transform.position = transform.position + transform.forward * pinchAmount * zoomSpeed * Time.deltaTime;
        }
    }
}
