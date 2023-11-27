using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Diagnostics;
public class Button : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;
    // Start is called before the first frame update
   

    public void GoToInstructions()
    {
        SceneManager.LoadScene("InfoScreen");
    }

    public void PlayGame()
    {
        string playerName = nameInput.text;
        UnityEngine.Debug.Log("Your name is: " + playerName);

        // Store the player's name in persistent data
        GameControl.control.SetName(playerName);

        // Set the player's score to 0 at the beginning of the game
        GameControl.control.SetScore(0);

        SceneManager.LoadScene("Level 1");
    }

    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
