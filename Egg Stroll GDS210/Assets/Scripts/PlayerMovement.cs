using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{

    //Jumping
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float jumpForce;
    private Rigidbody2D rb;
    public ParticleSystem jumpEffect;
    public GameObject player;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        //Jumping
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
            Instantiate(jumpEffect, player.transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {

            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            } else
            {
                isJumping = false;
            }

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SoundManager.PlaySound("eggCrack");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            SoundManager.PlaySound("jump");
        }

    }
}
