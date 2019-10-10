using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ScoreController : MonoBehaviour
{
    private int ScoreOfPlayer1 = 0;
    private int ScoreOfPlayer2 = 0;

    public GameObject scoreTextofPlayer1;
    public GameObject scoreTextofPlayer2;

    [SerializeField]
    private int WinnerGoal;


    void Update()
    {
        if (this.ScoreOfPlayer1 >= WinnerGoal || this.ScoreOfPlayer2 >= WinnerGoal) 
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }

    private void FixedUpdate()
    {
        Text UIScorePlayer1 = this.scoreTextofPlayer1.GetComponent<Text>();
        UIScorePlayer1.text = this.ScoreOfPlayer1.ToString();

        Text UIScorePlayer2 = this.scoreTextofPlayer2.GetComponent<Text>();
        UIScorePlayer2.text = this.ScoreOfPlayer2.ToString();
    }

    public void goalPlayerOne() 
    {
        this.ScoreOfPlayer1++;
    }
    public void goalPlayerTwo() 
    {
        this.ScoreOfPlayer2++;
    }
}
