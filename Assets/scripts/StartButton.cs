using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("the game start");
        SceneManager.LoadScene("GameScene");
    }
    public void StartGameAI()
    {
        Debug.Log("the game start");
        SceneManager.LoadScene("GameSceneAI");
    }
    public void BackToMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void About() 
    {
        SceneManager.LoadScene("About");
    }
}
