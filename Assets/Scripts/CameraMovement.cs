using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public bool invertCamera = false;

    private float pitch = 0f;
    private float yaw = 0f;

    void Update()
    {
        // First touch input will control the camera rotation
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            int inverted = invertCamera == true ? 1 : -1;

            pitch += Input.GetTouch(0).deltaPosition.y * cameraSpeed * inverted * Time.deltaTime;
            yaw += Input.GetTouch(0).deltaPosition.x * cameraSpeed * Time.deltaTime;

            pitch = Mathf.Clamp(pitch, -90, 90);

            transform.eulerAngles = new Vector3(pitch, yaw, 0);
        }
        if (Input.GetMouseButton(0)) {
            int inverted = invertCamera == true ? 1 : -1;

            pitch += Input.mousePosition.y * cameraSpeed * inverted * Time.deltaTime;
            yaw += Input.mousePosition.x * cameraSpeed * Time.deltaTime;

            pitch = Mathf.Clamp(pitch, -90, 90);

            // transform.eulerAngles = new Vector3(pitch, yaw, 0);
            // transform.Rotate(new Vector3())
        }
    }
}
