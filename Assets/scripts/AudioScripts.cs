using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScripts : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource PlayerSound;
    
    public AudioSource gameBacGroundSound;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketsPlayer1" || collision.gameObject.name == "RacketsPlayer2") 
        {
            this.PlayerSound.Play();
        }
        else 
        {
            this.wallSound.Play();
        }
    }
}
