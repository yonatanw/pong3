using UnityEngine;
using System.Collections;

public class PlayerMovement_02 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float howLongIsPressed;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float accel = howLongIsPressed * 15f;
        // Debug.Log(howLongIsPressed);
        if (Input.GetKey(KeyCode.D))
        {
            //rb.velocity = new Vector2(moveSpeed, 0);

            // Debug.Log("Right");
            howLongIsPressed += Time.deltaTime;
        rb.AddForce (Vector2.right * Time.deltaTime);
                //= new Vector3(moveSpeed + accel, 0, 0);


        }
        if (Input.GetKey(KeyCode.A))
        {
            //rb.velocity = new Vector2(moveSpeed, 0);

            // Debug.Log("Left");
            rb.velocity = new Vector3((moveSpeed + accel) * -1, 0, 0);
            howLongIsPressed += Time.deltaTime;

        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            howLongIsPressed = 0;



        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            howLongIsPressed = 0;



        }
    }
}
