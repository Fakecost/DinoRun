using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D  m_Rigibody2D;
    public float yForce = 100f;
    private bool _jump = true;
    Animator anim;
    BoxCollider2D box;
    [SerializeField]Score score;


    // Start is called before the first frame update
    void Start()
    {
        m_Rigibody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")&&_jump)
        {
            m_Rigibody2D.velocity = Vector2.up * yForce;
            _jump = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Tile")
        {
            _jump = true;
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            score.SetScore0();
            anim.SetBool("IsDead", true);
            Destroy(box);
        }
    }

}
