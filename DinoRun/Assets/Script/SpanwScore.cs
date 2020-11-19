using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject score;
    public GameObject scoreprefab;
    void Start()
    {
           if(GameObject.FindGameObjectsWithTag("Score").Length ==0)
            Instantiate(scoreprefab, score.transform.position, score.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
