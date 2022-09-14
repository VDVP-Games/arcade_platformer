using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_menu : MonoBehaviour
{
    public Behaviour Inventory_Canvas;
    public bool PauseGame ;
    public GameObject pauseGameMenu;

    void Start()
    {
        Inventory_Canvas.enabled = !Inventory_Canvas.enabled;
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (PauseGame)
                Resume();
            else
                Pause();
            Inventory_Canvas.enabled = !Inventory_Canvas.enabled;
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

    public void Level_exit()
    {
        PlayerPrefs.SetInt("time_coins", 0);
        PlayerPrefs.SetInt("c1", 0);
        PlayerPrefs.SetInt("c2", 0);
        PlayerPrefs.SetInt("c3", 0);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
