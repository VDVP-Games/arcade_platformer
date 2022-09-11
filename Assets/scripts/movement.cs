using System.Collections;
using System;
using System.Timers;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer spr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float Axis = Input.GetAxis("Horizontal");
        if (Axis < 0 && !Input.GetKey("l"))
        {
            anim.SetBool("running", true);
            spr.flipX = true;
            rb.velocity = new Vector2(Axis * 7, rb.velocity.y);
        }
        else if (Axis > 0 && !Input.GetKey("l"))
        {
            anim.SetBool("running", true);
            spr.flipX = false;
            rb.velocity = new Vector2(Axis * 7, rb.velocity.y);
        }
        else
        {
            anim.SetBool("running", false);
        }

        if (Input.GetKeyDown("space") && Math.Abs(rb.velocity.y) < 0.001)
        {
            anim.SetBool("jumping", true);
            rb.velocity = new Vector3(rb.velocity.x, 15, 0);
        }
        if (rb.velocity.y < 0.001)
        {
            anim.SetBool("jumping", false);
            anim.SetBool("fall", true);
        }
        if (Math.Abs(rb.velocity.y) < 0.001)
        {
            anim.SetBool("jumping", false);
            anim.SetBool("fall", false);
        }

    }
}
