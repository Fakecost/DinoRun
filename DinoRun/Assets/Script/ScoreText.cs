using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI highScore;
    int score;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()

    {
        highscore = Score.instance.GetHighScore() ;
        highScore.text = highscore.ToString();
        score = Score.instance.GetScore();
        text.text = score.ToString();
    }

    

}
