using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 5f;
    

    private Rigidbody2D rb;
    
    public float deathY = -2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.y < deathY || speed < 5)
        {
            Respawn();
        }

        void Respawn()
        {
            
            transform.position = new Vector3(-10.31f, 0.22f, 0);
           
        }


    }
}
