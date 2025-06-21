using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public int facingDirection = 1;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anm;

    // FixedUpdate is called 50x per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        anm.SetFloat("horizontal", Mathf.Abs(moveHorizontal));
        anm.SetFloat("vertical", Mathf.Abs(moveVertical));
        if ((moveHorizontal > 0 && transform.localScale.x < 0) || (moveHorizontal < 0 && transform.localScale.x > 0))
        {
            Flip();
        }
        rb.linearVelocity = new Vector2(moveHorizontal, moveVertical) * speed;
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(facingDirection, transform.localScale.y, transform.localScale.z);
    }
}
