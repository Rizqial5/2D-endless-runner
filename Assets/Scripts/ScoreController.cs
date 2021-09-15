using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    private int currentScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        //reset
        currentScore = 0;
    }

    public float GetCureentScore()
    {
        return currentScore;
    }

    public void IncreaseCurrentScore(int increment)
    {
        currentScore += increment;
    }

    public void FinishScoring()
    {
        //set hihg dcore
        if(currentScore > ScoreData.highScore)
        {
            ScoreData.highScore = currentScore;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
