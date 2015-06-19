using UnityEngine;
using System.Collections;


public class Ball_movement_Backup : MonoBehaviour
{
    static float ballSpeedY = Random.Range(-5, -12);
    static float ballSpeedX = Random.Range(-10, 10);
    static float currentSpeedY;
    static float currentSpeedX;
    static float accel;
    public Rigidbody2D rb;


    // Use this for initialization


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(ballSpeedX + accel, ballSpeedY + accel);



    }
    //set trigger with player

    //collisions
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            ballSpeedY = ballSpeedY * -1;



        }
        if (other.gameObject.tag == "Killzone")
        {
            
            //Debug.Log("YOU LOSE");
            //Destroy(this.gameObject);
            //Destroy(GameObject.FindWithTag("Player"));
            //ScoreKeeper.TakeaLife();

        }
        if (other.gameObject.tag == "Wall")
        {
            //Debug.Log("Hit Racket!");
            ballSpeedX = ballSpeedX * -1;

        }
        if (other.gameObject.tag == "Ceiling")
        {
            //Debug.Log("I hit the ceiling");
            ballSpeedY = ballSpeedY * -1;

        }




    }


}
