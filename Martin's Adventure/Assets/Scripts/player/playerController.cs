using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    
    public float speed = 200f;
    [HideInInspector]
    public float jumpForce = 300f;
    public bool isJumping = false;
    public bool isGrounded = false;
    private float movement;
    private Vector3 velocity = Vector3.zero;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float groundcheckradius;
    public LayerMask colLayer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundcheckradius, colLayer);

        movement = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            isJumping = true;
            
        }
    }
     void FixedUpdate()
    {        
        
        Move(movement);
    }

    void Move(float _movement)
    {
        Vector3 targetvelocity = new Vector2(movement * speed * Time.deltaTime, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetvelocity, ref velocity, 0.05f);
        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundcheckradius);
    }
}
