using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float backwardForce = 2000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, - backwardForce * Time.deltaTime);

    }
}
