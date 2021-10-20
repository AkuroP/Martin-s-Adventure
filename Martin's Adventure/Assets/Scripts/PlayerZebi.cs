using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZebi : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded;

    void Start()
    {

    }


    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 4f), ForceMode2D.Impulse);
            isGrounded = false;
        }

    }
}
