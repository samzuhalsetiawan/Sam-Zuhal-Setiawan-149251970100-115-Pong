using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Sam Zuhal Setiawan - 149251970100-115");
    }

    public void DebugAuthor()
    {
        Debug.Log("Created By: Sam Zuhal Setiawan :)");
    }
}
