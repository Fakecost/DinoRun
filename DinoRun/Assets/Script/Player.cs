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

    private bool _isDead = false;
    


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
        if (_isDead)
            Score.instance.SetScore0();
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began&&_jump)
            {
                m_Rigibody2D.velocity = Vector2.up * yForce;
                _jump = false;
            }
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
            _isDead = true;
            Scene.instance.breakScene();
            Score.instance.UpdateHighScore();
            anim.SetBool("IsDead", true);
            Destroy(box);
            StartCoroutine(WaitAndNext());
        }
    }
    IEnumerator WaitAndNext()
    {
        
        yield return new WaitForSeconds(3);
        Scene.instance.LoadNextScene();
    }



}
