using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int maxScore;

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        if (leftScore >= maxScore)
        {
            EndGame();
        }
    }

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        if (rightScore >= maxScore)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
