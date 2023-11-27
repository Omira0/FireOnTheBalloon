using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class TextController : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text sceneText;
    [SerializeField] TMP_Text nameText;
    [SerializeField] int level;

    public const int DEFAULT_POINTS = 5;

    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
        score = GameControl.control.GetScore();
        DisplayName();
        DisplayScene();
        DisplayScore();
    }

    

    public void AddPoints(int points)
    {
        score += points;
        UnityEngine.Debug.Log("score: " + score);
        DisplayScore();
        GameControl.control.SetScore(GameControl.control.GetScore() + score);
    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);

    }

    private void DisplayName()
    {
        nameText.text = "Hello " + GameControl.control.GetName() + "!";
    }

    private void DisplayScore()
    {
        scoreText.text = "Score: " + GameControl.control.GetScore();
    }

    private void DisplayScene()
    {
        sceneText.text = "Level: " + level;
    }
}

