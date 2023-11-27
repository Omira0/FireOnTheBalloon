using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //To load the next scene when it press the button.
    }
    public void QuitGame()
    {
        Debug.Log("Quit the game"); //Just for Testing.
        Application.Quit(); //To quit the game.
    }
}
