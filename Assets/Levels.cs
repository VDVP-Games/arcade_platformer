﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void Level_1()
    {
        SceneManager.LoadScene(1);// загружать сцену по индексу
    }

}
