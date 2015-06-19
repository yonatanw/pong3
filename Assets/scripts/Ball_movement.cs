using UnityEngine;
using System.Collections;


public class Ball_movement : MonoBehaviour {
   static float ballSpeedY = Random.Range(-5,-12);
   static float ballSpeedX = Random.Range(-10, 10);
    static float accel;
    static float currentY;
    public float maxSpeed= 6;
   public Rigidbody2D  rb;
   public float destroyTime = 2;
  

	// Use this for initialization
  
	
    void Start () {
      rb = GetComponent<Rigidbody2D>();
      
	}
   
	
    void FixedUpdate () {
        //accel = accel+ 2*(Time.deltaTime);
        currentY = ballSpeedY + accel;
        rb.velocity = new Vector2(ballSpeedX, ballSpeedY);
        if (ballSpeedY>maxSpeed)
        {
            ballSpeedY = maxSpeed;
        }
        Debug.Log(accel);
        
        
    } 
        

    //collisions
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            
            ballSpeedY *= -1;
            ballSpeedY += 2;
            ballSpeedX = ballSpeedX + Random.Range(-5, 5);
            
            
        }
        if (other.gameObject.tag == "Killzone")
        {
            transform.position = new Vector2(0, 5);
            ballSpeedY = Random.Range(-5, -12);
            ballSpeedX = Random.Range(-10, 10);
            rb.velocity = new Vector2(ballSpeedX, ballSpeedY);

            ScoreKeeper.lives = ScoreKeeper.lives - 1;
           

            //Debug.Log("YOU LOSE");
            //Destroy(this.gameObject);
            //Destroy(GameObject.FindWithTag("Player"));
            
        }
        if (other.gameObject.tag == "Wall")
        {
            
            ballSpeedX = ballSpeedX * -1;

            

        }
        if (other.gameObject.tag == "Ceiling")
        {
            //Debug.Log("I hit the ceiling");
            ballSpeedY = ballSpeedY * -1;
            ballSpeedY -= 2;

        }
        if (other.gameObject.tag == "BlockBody")
        {

          ballSpeedY = ballSpeedY * -1;
         Destroy(other.gameObject, destroyTime);
            //DestroyBlock.mDestroyblock();
          DestroyBlock destroyBlock = new DestroyBlock(); 
            destroyBlock.mDestroyBlock();
            ScoreKeeper.score = ScoreKeeper.score + 1000;



        }
        if (other.gameObject.tag == "BlockSide")
        {

            ballSpeedX = ballSpeedX * -1;
            Destroy(other.gameObject, destroyTime);
            //DestroyBlock.mDestroyblock();
            DestroyBlock destroyBlock = new DestroyBlock();
            destroyBlock.mDestroyBlock();
            ScoreKeeper.score = ScoreKeeper.score + 1000;




        }
      
        
        
     
    }
 
	
}
