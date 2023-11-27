using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] int score;
    // Start is called before the first frame update
    public static GameControl control;
    

    private void Awake()
    {
        if(control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        } else 
        {
            Destroy(gameObject);
        }
    }

    public void SetName(string n)
    {
        playerName = n;
    }

    public void SetScore(int s)
    {
        score = s;
    }

    public string GetName()
    {
        return playerName ?? "Hidden"; //If player doesn't set a name, they will show as Anon
    }

    public int GetScore()
    {
        return score;
    }
}
