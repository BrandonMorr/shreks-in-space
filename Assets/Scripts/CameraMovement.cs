using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public bool invertCamera = false;

    private float pitch = 0f;
    private float yaw = 0f;

    void Update()
    {
        // Mobile touch input, first touch input will control the camera rotation.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            int inverted = invertCamera == true ? 1 : -1;

            pitch += Input.GetTouch(0).deltaPosition.y * cameraSpeed * inverted * Time.deltaTime;
            yaw += Input.GetTouch(0).deltaPosition.x * cameraSpeed * Time.deltaTime;

            pitch = Mathf.Clamp(pitch, -90, 90);

            transform.eulerAngles = new Vector3(pitch, yaw, 0);
        }
        // Mouse button input, fires on mousedown.
        if (Input.GetMouseButton(0)) {
            int inverted = invertCamera == true ? 1 : -1;

            pitch = Input.GetAxis("Mouse Y") * (cameraSpeed * 100) * inverted * Time.deltaTime;
            yaw = Input.GetAxis("Mouse X") * (cameraSpeed * 100) * Time.deltaTime;

            pitch = Mathf.Clamp(pitch, -90, 90);

            transform.Rotate(pitch, yaw, 0);
        }
    }
}
