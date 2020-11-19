using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gametime : MonoBehaviour
{
    private float _gameTime;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale <=4)
        Time.timeScale += 0.00001f;
        
    }
}
