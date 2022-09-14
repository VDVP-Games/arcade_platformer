using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_Menu : MonoBehaviour
{
    public Text coinsText;
    [SerializeField] private GameObject Inventory_Canvas;


    void Start()
    {
        Debug.Log(Inventory_Canvas);
        Inventory_Canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Time.timeScale = 0f;
            Debug.Log("end");

            int coins = PlayerPrefs.GetInt("c1") + PlayerPrefs.GetInt("c2") + PlayerPrefs.GetInt("c3");

            int lcoins = SceneManager.GetActiveScene().buildIndex;
            string str = "coins" + lcoins.ToString();
            lcoins = PlayerPrefs.GetInt(str);

            if (coins > lcoins)
            {
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + coins - lcoins);
                lcoins = coins;
            }
            PlayerPrefs.SetInt(str, lcoins);
            coinsText.text = "Collected coins " + lcoins.ToString() + " / 3";
            Inventory_Canvas.SetActive(true);

            PlayerPrefs.SetInt("time_coins", 0);
            PlayerPrefs.SetInt("c1", 0);
            PlayerPrefs.SetInt("c2", 0);
            PlayerPrefs.SetInt("c3", 0);
        }
    }
}
