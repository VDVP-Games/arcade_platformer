using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class swing : MonoBehaviour
{

    private Rigidbody2D rb;
    private DistanceJoint2D hook;
    private LineRenderer line;
    [SerializeField] private Material image;

    private Animator anim;
    private GameObject node;
    private List<GameObject> nodes = new List<GameObject>();

    int cd = 0;
    bool enter = false;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
        hook = GetComponent<DistanceJoint2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("node"))
        {
            if(nodes.Count==0)
            {
                node = collision.gameObject;
            }
            enter = true;
            nodes.Add(collision.gameObject);
            collision.gameObject.GetComponent<Animator>().SetBool("active",true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("1");
        if(collision.gameObject.CompareTag("node"))
        {
            nodes.Remove(collision.gameObject);
            collision.gameObject.GetComponent<Animator>().SetBool("active", false);
        }
    }


    private void Update()
    {
        if (nodes.Count!=0 && !Input.GetKey("l"))
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if(Vector2.Distance(nodes[i].transform.position,rb.transform.position)< Vector2.Distance(node.transform.position,rb.transform.position))
                {
                    node.GetComponent<Animator>().SetBool("active", false);
                    nodes[i].GetComponent<Animator>().SetBool("active", true);
                    node = nodes[i];
                }
            }
        }
        if (Input.GetKey("l") && nodes.Count!=0)
        {
            rb.gravityScale = 0;
            rb.AddForce(new Vector3(0, -6, 0),ForceMode2D.Force);
            hook.enabled = true;
            line.enabled = true;
            line.SetPosition(1, new Vector3(node.transform.position.x - rb.transform.position.x, node.transform
                .position.y - rb.transform.position.y, (float)1));
            float Axis = Input.GetAxis("Horizontal");
            if (Axis > 0)
            {
                rb.AddForce(new Vector3(Axis*2, -3, 0), ForceMode2D.Force);
            }
            if(Axis < 0)
            {
                rb.AddForce(new Vector3(Axis * 2, -3, 0), ForceMode2D.Force);
            }
        }
        else
        {
            line.enabled = false;
            rb.gravityScale = 5;
            hook.enabled = false;
        }
    }
}
