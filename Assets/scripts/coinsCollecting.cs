using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinsCollecting : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    public Sprite coin;

    [SerializeField] private Image coinCounter1;

    [SerializeField] private Image coinCounter2;

    [SerializeField] private Image coinCounter3;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            coinCounter1.sprite = coin;
            PlayerPrefs.SetInt("c1", 1);
            Debug.Log(PlayerPrefs.GetInt("c1"));
        }
        if (collision.gameObject.CompareTag("coin2"))
        {
            Destroy(collision.gameObject);
            coinCounter2.sprite = coin;
            PlayerPrefs.SetInt("c2", 1);
            Debug.Log(PlayerPrefs.GetInt("c2"));
        }
        if (collision.gameObject.CompareTag("coin3"))
        {
            Destroy(collision.gameObject);
            coinCounter3.sprite = coin;
            PlayerPrefs.SetInt("c3", 1);
            Debug.Log(PlayerPrefs.GetInt("c3"));
        }

    }

}
