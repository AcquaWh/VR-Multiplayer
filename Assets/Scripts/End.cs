﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("Home");
    }
    public void Exitgame()
    {
        Application.Quit();
    }
}
