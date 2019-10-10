using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionCharacteristics : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController score;

    void BounceonRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHight = collision.collider.bounds.size.y;

        float x;


        if (collision.gameObject.name == "RacketsPlayer1")
        {
            x = 1;
        }
        else {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHight;
        this.ballMovement.IncreasHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
        }
         void OnCollisionEnter2D(Collision2D collision)
          {
            if (collision.gameObject.name == "RacketsPlayer1" || collision.gameObject.name == "RacketsPlayer2")
            {
                this.BounceonRacket(collision);
            }
            else if (collision.gameObject.name == "wallRight")
            {
                this.score.goalPlayerOne();
                StartCoroutine(this.ballMovement.StartBall(false));
            }
            else if (collision.gameObject.name == "wallLeft") 
            {
                this.score.goalPlayerTwo();
                StartCoroutine(this.ballMovement.StartBall(true));
                
            }
         }

    
}
