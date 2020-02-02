using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    BallScript gameBall;
    int playerOneScore, playerTwoScore;
    [SerializeField]
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;
    }

    public void GoalScored(int playerNumber)
    {
        // increase the score for whichever player scored
        if (playerNumber == 1)
            playerOneScore++;
        else if (playerNumber == 2)
            playerTwoScore++;

        // now check if the player has won
        if (playerOneScore == 3)
            GameOver(1);
        else if (playerTwoScore == 3)
            GameOver(2);
        UpdateScoreText();

    }

    void UpdateScoreText()
    {
        scoreText.text = "Player One " + playerOneScore.ToString() + " - " + playerTwoScore.ToString() + " Player Two";
    }

    void GameOver(int winner)
    {
        // this is called when a player reaches 3 points 

        // reset the scores
        playerOneScore = 0;
        playerTwoScore = 0;
        gameBall.Reset();
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
