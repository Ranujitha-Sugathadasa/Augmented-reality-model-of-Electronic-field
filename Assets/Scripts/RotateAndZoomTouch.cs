using UnityEngine;

public class RotateAndZoomTouch : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Adjust rotation speed
    public float zoomSpeed = 5.0f;       // Adjust zoom speed

    private Vector2 lastTouchPosition; // Note: Store last touch position as Vector2

    void Update()
    {
        // Handle touches
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // Rotation (corrected to use consistent Vector2 types)
                Vector2 delta = touch.position - lastTouchPosition;
                transform.Rotate(Vector3.up, delta.x * rotationSpeed * Time.deltaTime);
                transform.Rotate(Vector3.right, delta.y * rotationSpeed * Time.deltaTime);

                lastTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                lastTouchPosition = Vector2.zero; // Reset to Vector2.zero
            }
        }

        // ... rest of the code (unchanged for zoom and other parts)
    }
}
