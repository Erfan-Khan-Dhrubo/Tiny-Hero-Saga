using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    // FixedUpdate is called 50x per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(moveHorizontal, moveVertical) * speed;
    }
}
