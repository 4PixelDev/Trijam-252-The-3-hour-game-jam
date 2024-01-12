using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float jumpForce = 10f;

    private Vector2 moveInput;

    // Flip
    private bool facingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        rb.velocity = new Vector2(moveInput.x * moveSpeed, rb.velocity.y);

        // flip character based on direction
        if (facingRight == false && moveInput.x < 0) { Flip(); }
        if (facingRight == true && moveInput.x > 0) { Flip(); }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
