using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public int raycastDistance = 10;

    private float gravity = 10f;
    private RaycastHit _hit;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));

        if (Physics.Raycast(ray, out _hit, raycastDistance))
        {
            if (Input.GetButtonDown("Fire1") && _hit.transform.CompareTag("Star"))
            {
                _hit.transform.gameObject.GetComponent<RotateCube>().ChangeDirection();
            }
        }

        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis);
        Vector3 velocity = direction * speed;

        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        controller.Move(velocity * Time.deltaTime);
    }
}
