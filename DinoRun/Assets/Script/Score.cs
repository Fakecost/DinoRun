using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public static Score instance;
    private float scoreValue = 0;
    public int intScore;
    private int HighScore;
    private float scorePoint = 0f;
    

    //[SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
       
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(scorePoint);
        scoreValue += scorePoint;        
        intScore = (int)scoreValue;
        //text.text = intScore.ToString();
    }

    public void SetScore0()
    {
        scorePoint = 0;
    }
    public void SetScore()
    {
        
            scorePoint = 0.01f;
        
    }

    public void UpdateHighScore()
    {
        if(intScore > HighScore)
        {
            HighScore = intScore;
        }
    }

    public int GetScore()
    {
        return intScore;
    }

    public int GetHighScore()
    {
        return HighScore;
    }

    public void Reset()
    {
        scoreValue = 0;
    }

  
}
