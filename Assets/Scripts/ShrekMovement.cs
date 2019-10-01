using UnityEngine;

public class ShrekMovement : MonoBehaviour
{
    void Awake()
    {
        float scale = Random.Range(1f, 3f);
        transform.localScale = new Vector3(scale, scale, scale);
    }

    void Update()
    {
        // Rotate on x axis
        transform.Rotate(Vector3.right * Time.deltaTime);

        // Rotate on y axis
        transform.Rotate(Vector3.up * Time.deltaTime);
    }
}
