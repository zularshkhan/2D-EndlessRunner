using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpforce;
    private bool isGrounded;
    public GameObject death;
    public AudioSource audiosource;

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            jump();
        }
    }


    void jump()
    {
        audiosource.Play();
        rb.AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

        if(collision.gameObject.tag== "Enemy")
        {
            Destroy(gameObject);
            Instantiate(death, transform.position, Quaternion.identity);
        }
    }

}
