using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public bool gameOver = false;
    public GameObject bird;
    public GameObject RestartUI;
    public GameObject ScoreUI;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public void AddScore()
    {
        if (!gameOver)
        {
            score++;
        }
        ScoreUI.GetComponent<TMP_Text>().text = $"Счет: {score}";
    }
    
    public void GameOver()
    {
        gameOver = true;
        Destroy(bird);
        ScoreUI.SetActive(false);
        RestartUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
    }

    public void Exit()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}