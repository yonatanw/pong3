using UnityEngine;
using System.Collections;


public class Ball_movement : MonoBehaviour {
   static float ballSpeedY = Random.Range(-5,-12);
   static float ballSpeedX = Random.Range(-5, 5);
    static float accel;
    static float currentY;
    public float maxSpeed= 6;
   public Rigidbody2D  rb;
   public float destroyTime = 2;
   // GameObject.Find("Player").transform.position.x;
    private float playerPosition= 0.0f;
    private float ballPosition = 0.0f;
    private float playerMiddleLength = 0.0f;
    private float ballHitPos = 0;
    public float racketAngle = 0;
    public float racketSpeedInfluence = 1;
    private float racketSpeed = 0;
	// Use this for initialization
  
	
    void Start () {
      rb = GetComponent<Rigidbody2D>();
      playerMiddleLength = (GameObject.Find("Player").transform.localScale.x)/4;
      
	}
   
	
    void FixedUpdate () {
      
        //Debug.Log("Player position is" + playerPosition + "ball position is " + ballPosition);
      //  Debug.Log(playerPosition);
        //accel = accel+ 2*(Time.deltaTime);
        currentY = ballSpeedY + accel;
        rb.velocity = new Vector2(ballSpeedX, ballSpeedY);
        if (ballSpeedY>maxSpeed)
        {
            ballSpeedY = maxSpeed;
        }
        //Debug.Log(accel);
        
        
    } 
        

    //collisions
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject Player = GameObject.Find("Player");
        PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();
        racketSpeed = ((playerMovement.playerVelocity) * racketSpeedInfluence);
        //Debug.Log(PlayerMovement.playerVelocity);
        playerPosition = GameObject.Find("Player").transform.position.x;
        ballPosition = GameObject.Find("Ball").transform.position.x;
        ballHitPos = ballPosition - playerPosition;
        
        if (other.gameObject.tag == "Player")
        {
            if ((playerMiddleLength*-1)<ballHitPos && ballHitPos<playerMiddleLength)
            {
                //ballSpeedY *= -1;
              //  Debug.Log("middle!");
            }
            if (ballHitPos>playerMiddleLength)
            {
                
                ballSpeedX =+ racketAngle;
                //Debug.Log("right!");
            }
            if (ballHitPos < (playerMiddleLength*-1))
            {

                ballSpeedX =+ (racketAngle)*-1;
               
                //Debug.Log("left");
            }
           // Debug.Log(ballHitPos);   
            ballSpeedY *= -1;
            ballSpeedY += 2;
            ballSpeedX = ballSpeedX + racketSpeed + Random.Range(-5, 5);
          

            
            
            
        }
        if (other.gameObject.tag == "Killzone")
        {
            transform.position = new Vector2(0, 5);
            ballSpeedY = Random.Range(-5, -12);
            ballSpeedX = Random.Range(-5, 5);
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
          //DestroyBlock destroyBlock = new DestroyBlock(); 
            //destroyBlock.mDestroyBlock();
            ScoreKeeper.score = ScoreKeeper.score + 1;



        }
        if (other.gameObject.tag == "BlockSide")
        {

            ballSpeedX = ballSpeedX * -1;
            //Destroy(other.gameObject, destroyTime);
            Destroy(other.transform.parent.gameObject);
           // Debug.Log(other.gameObject);
            //Destroy(gameObject(player), destroyTime);
            //DestroyBlock.mDestroyblock();
            //DestroyBlock destroyBlock = new DestroyBlock();
            //destroyBlock.mDestroyBlock();
            ScoreKeeper.score = ScoreKeeper.score + 1;




        }
      
        
        
     
    }
 
	
}
