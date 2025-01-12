using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 3f;
    private Rigidbody2D rb;
    public float horizontalLimit = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * horizontalSpeed, 0);

        float clampedX = Mathf.Clamp(transform.position.x, -horizontalLimit, horizontalLimit);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
