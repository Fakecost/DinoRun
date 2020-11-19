using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D m_rigidbody2D;
    public float _speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rigidbody2D.velocity = Vector2.left * _speed;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
