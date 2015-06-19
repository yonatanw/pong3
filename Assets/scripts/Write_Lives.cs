using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Write_Lives : MonoBehaviour {
    Text instruction;
    static int livesint = 10;
    
   // string livesstring = livesint.ToString();
   
	// Use this for initialization
	void Start () {
        instruction = GetComponent<Text>();
       

	
	}
	
	// Update is called once per frame
	void Update () {
        instruction.text = "Lives Left: " + ScoreKeeper.lives.ToString();

	}
}
