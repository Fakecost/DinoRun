using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float scoreValue = 0;
    private int intScore;
    private float scorePoint = 0.01f;
    [SerializeField] TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue += scorePoint;        
        intScore = (int)scoreValue;
        text.text = intScore.ToString();
    }

    public void SetScore0()
    {
        scorePoint = 0;
    }
}
