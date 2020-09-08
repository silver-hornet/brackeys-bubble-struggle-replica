using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] Rigidbody2D rb;
    float movement = 0f;

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed; //GetAxis is smoother; GetAxisRaw is snappier    
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
