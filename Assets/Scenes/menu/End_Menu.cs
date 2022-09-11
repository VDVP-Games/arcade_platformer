using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_Menu : MonoBehaviour
{

    public Behaviour Inventory_Canvas;
    public bool PauseGame;
    public GameObject pauseGameMenu;

    void Start()
    {
        Inventory_Canvas.enabled = !Inventory_Canvas.enabled;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Inventory_Canvas.enabled = !Inventory_Canvas.enabled;
            Debug.Log("end");
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            int coins = PlayerPrefs.GetInt("c1") + PlayerPrefs.GetInt("c2") + PlayerPrefs.GetInt("c3");
            int lcoins = SceneManager.GetActiveScene().buildIndex;
            string str = "coins" + lcoins.ToString();
            lcoins = PlayerPrefs.GetInt(str);
            Debug.Log(coins);
            if (coins > lcoins)
            {
                lcoins = coins;
                PlayerPrefs.SetInt("coins",lcoins-coins);
            }
            PlayerPrefs.SetInt(str,lcoins);
            PlayerPrefs.SetInt("time_coins", 0);
            PlayerPrefs.SetInt("c1", 0);
            PlayerPrefs.SetInt("c2", 0);
            PlayerPrefs.SetInt("c3", 0);
            Debug.Log(PlayerPrefs.GetInt(str));
        }
    }
}
