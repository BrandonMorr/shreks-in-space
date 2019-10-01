using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float spinForce;

    private bool isSpinning = false;

    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(0, spinForce * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }

    public void ChangeDirection()
    {
        isSpinning = !isSpinning;
    }
}
