using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float minspeed;
    public float maxspeed;
    private Transform backPoint;
    private Animator animator;
    private Rigidbody2D rig;


    void Start() 
    {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
    
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (GameController.current.PlayerIsAlive)
        {
            
        
        //transform.Translate(Vector3.left * speed * Time.deltaTime);

        rig.velocity = new Vector2(-speed, rig.velocity.y);

        if (transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
        }
    }

    //Metodo verificar colisão d bala no inimigo
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "bullet")
        {
            GetComponent<CircleCollider2D>().enabled = false; 
            GameController.current.AddScore(10);
            animator.SetTrigger("Destroy");
            Destroy(gameObject, 1f);
        }
    }
}
