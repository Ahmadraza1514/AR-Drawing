using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        // Get input for rotation around X and Y axes
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed;
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed;

        // Rotate the camera around X and Y axes
        transform.Rotate(Vector3.right, rotationX);
        transform.Rotate(Vector3.up, rotationY);
    }
}
