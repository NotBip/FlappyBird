using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class LogicManager : MonoBehaviour
{

    private int playerScore; 
    public Text scoreTest; 
    public GameObject gameOverScreen; 


    [ContextMenu("Increase Player Score")]
    public void addScore(int score)
    { 
        playerScore += score; 
        scoreTest.text = playerScore.ToString(); 
    }

    public void restartGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameOver() 
    { 
        gameOverScreen.SetActive(true); 
    }
}
