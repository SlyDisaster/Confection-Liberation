using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int gameScore;
    public Text winText;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameScore.ToString();

        //check IF gameScore is = to 100

        if(gameScore == 100)
        {
            YouWin();
           //add a coroutine that takes the player to the end screen after 5 seconds
        }
    }

    void YouWin()
    {
        //turn text on that says you win
        winText.enabled = true;
    }
}
