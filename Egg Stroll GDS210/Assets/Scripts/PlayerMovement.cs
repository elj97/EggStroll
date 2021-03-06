﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    //Phone Input
    private Touch touch;
    private float myTouchDT = 0f;

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

    public float jumpEffectLower = -5f;

    private bool jumpSoundPlayed = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        //When jumped play sound, if sound has not played (soundplayed false to true), if isgrounded true then set soundplayed to false
        if (isJumping == true && jumpSoundPlayed == false)
        {
            SoundManager.PlaySound("eggyJump");
            jumpSoundPlayed = true;
        }
        if (isJumping == false)
        {
            jumpSoundPlayed = false;
        }


        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            //PC Input
            
            if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                //rb.velocity = Vector2.up * jumpForce;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                Vector3 jumpEffectPos = new Vector3(0f, jumpEffectLower, 0f);
                Instantiate(jumpEffect, player.transform.position + jumpEffectPos, jumpEffect.transform.rotation);
            }

            if (Input.GetKey(KeyCode.Space) && isJumping == true)
            {

                if (jumpTimeCounter > 0)
                {
                    //rb.velocity = Vector2.up * jumpForce;
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    jumpTimeCounter -= Time.deltaTime;
                }
                else
                {
                    isJumping = false;
                }

            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                isJumping = false;
            }
        }
        else if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            //Phone Input

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                myTouchDT = myTouchDT + Time.deltaTime;

                if (isGrounded == true)
                {
                    isJumping = true;
                    jumpTimeCounter = jumpTime;
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    Vector3 jumpEffectPos = new Vector3(0f, jumpEffectLower, 0f);
                    Instantiate(jumpEffect, player.transform.position + jumpEffectPos, jumpEffect.transform.rotation);
                }
            }
            if (Input.touchCount < 1)
            {
                myTouchDT = 0f;
            }

            if (myTouchDT > 0)
            {
                if (isJumping == true)
                {

                    if (jumpTimeCounter > 0)
                    {
                        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                        jumpTimeCounter -= Time.deltaTime;
                    }
                    else
                    {
                        isJumping = false;
                    }

                }
            }
            if (myTouchDT == 0f)
            {
                isJumping = false;
            }
        }


        //Sound Effects
        if (Input.GetKeyDown(KeyCode.E))
        {
            SoundManager.PlaySound("eggCrack");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            SoundManager.PlaySound("eggyJump");
        }
        
    }

}
