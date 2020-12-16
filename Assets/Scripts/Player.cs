using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rig;
    private bool isJumping;

    public float Jumpforce;
    public GameObject bullet;
    public Transform firePoint;

    public GameObject smoke;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);

        if(Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rig.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
            isJumping = true;
            smoke.SetActive(true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Ground" )
        {
            isJumping = false;
            smoke.SetActive(false);
        }
    }
}
