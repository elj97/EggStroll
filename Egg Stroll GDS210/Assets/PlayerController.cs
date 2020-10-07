using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpHeight = 5f;
    public bool jumped = false;
    private Rigidbody2D _rigidBody2D;

    void Awake ()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space) && jumped == false)
        {
            _rigidBody2D.AddForce(Vector2.up * jumpHeight);
            jumped = true;
        }
    }

    private void OnCollisionEnter2D (Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            jumped = false;
        }
    }

}
