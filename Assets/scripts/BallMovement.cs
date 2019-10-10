using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 400f;
    [SerializeField]
    private float extraSpeedPerContact = 50f ;
    [SerializeField]
    private float maxExtraSpeed = 1000f;

    int hitCounter = 0;


    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.positionBall(isStartingPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1) 
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else {
            this.MoveBall(new Vector2(1, 0));
        }
    }

    void positionBall(bool isStartingPlayer1) 
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isStartingPlayer1) 
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else 
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }
    }
    public void MoveBall(Vector2 dir) 
    {
        dir = dir.normalized;
        float speed = this.movementSpeed + this.hitCounter * extraSpeedPerContact;
        
        Rigidbody2D rb2D = this.gameObject.GetComponent<Rigidbody2D>();
        rb2D.velocity = dir * speed;

    }
    public void IncreasHitCounter() 
    {
        if (this.hitCounter * this.extraSpeedPerContact <= this.maxExtraSpeed) 
        {
            this.hitCounter++;
        }
    }

}
