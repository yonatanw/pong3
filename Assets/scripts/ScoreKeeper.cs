using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
     public static int lives = 3;
     public static int score = 0;
     
   
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lives < 1) {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("Ball"));
            Debug.Log(lives);
        }
	
	}
}
