using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Write_Score : MonoBehaviour
{
    Text score;
    static int scoreint = 10;

    // string livesstring = livesint.ToString();

    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();



    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Your score: "+ (10*ScoreKeeper.score).ToString();

    }
}
