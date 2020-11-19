using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] EnemyPrefab;

    public GameObject[] SpawnPoint;  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            
            int ran = Random.Range(0, 2);
            var newEnemy = Instantiate(EnemyPrefab[ran], SpawnPoint[ran].transform.position, Quaternion.identity);
            newEnemy.transform.parent = gameObject.transform;
        }
    }
}
