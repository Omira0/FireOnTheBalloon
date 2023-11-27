using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //To load the next scene when it press the button.
    }
    public void QuitGame()
    {
        Debug.Log("Quit the game"); //Just for Testing.
        Application.Quit(); //To quit the game.
    }
}
