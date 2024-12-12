using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "enemy")
        {
            GameManager.instance.GameOver();
        }
    }
}
