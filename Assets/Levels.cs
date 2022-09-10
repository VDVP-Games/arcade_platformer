﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public Text coinsText;
    //public int coin;

    private void Start()
    {
       
        int coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
        Debug.Log(coins);
    }

    public void Level_1()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 0){
            SceneManager.LoadScene(1);// загружать сцену по индексу
     
           // PlayerPrefs.SetInt("coins", coins);
        }
        Debug.Log(coins);
    }

    public void Level_2()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 2)
        {
            SceneManager.LoadScene(2);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_3()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 4)
        {
            SceneManager.LoadScene(3);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_4()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 7)
        {
            SceneManager.LoadScene(4);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_5()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 10)
        {
            SceneManager.LoadScene(5);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_6()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 13)
        {
            SceneManager.LoadScene(6);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_7()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 16)
        {
            SceneManager.LoadScene(7);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_8()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 19)
        {
            SceneManager.LoadScene(8);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_9()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 21)
        {
            SceneManager.LoadScene(9);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_10()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 24)
        {
            SceneManager.LoadScene(10);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_11()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 27)
        {
            SceneManager.LoadScene(11);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }

    public void Level_12()
    {
        int coins = PlayerPrefs.GetInt("coins");
        if (coins >= 30)
        {
            SceneManager.LoadScene(12);// загружать сцену по индексу
        }
        Debug.Log(coins);
    }
}