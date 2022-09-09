using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggers : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    int cd = 0;
    bool enter = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trigger"))
        {
            enter = true;
            anim = collision.gameObject.GetComponent<Animator>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enter = false;
    }


    private void Update()
    {
        if ((Input.GetKeyDown("f")) && cd == 0 && enter && !(anim.GetBool("active")))
        {
            cd += 200;
            Debug.Log(!(anim.GetBool("active")));
            anim.SetBool("active", !(anim.GetBool("active")));
        }
        if (cd!=0)
        {
            cd--;
        }
    }

}
