﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int errorValue = 0;
    TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreValue != 240)
        {
            score.text = "Errores: " + errorValue + "  Puntos: " + scoreValue;
        } else
        {
            Time.timeScale = 0;
            Debug.Log("Has ganado");
            SceneManager.LoadScene("Won");

        }
        if(errorValue == 3)
        {
            Time.timeScale = 0;
            Debug.Log("Has perdido");
            SceneManager.LoadScene("Lost");

        }
        
    }
}
