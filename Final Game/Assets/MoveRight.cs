using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    private bool isWaiting = true;

    public float speed = 5f;

    public Animator animator;

    private Rigidbody2D rb;
    
    public float deathY = -2f;

    private void Start()
    {
        transform.position = new Vector3(-14.05f, -1.28f, 0);
        animator.SetFloat("speed", 0);

        {
            StartCoroutine(WaitBeforeStart());
        }
        IEnumerator WaitBeforeStart()
        {
            yield return new
                WaitForSeconds(1);
            isWaiting = false;
            
        }

        rb = GetComponent<Rigidbody2D>();

        

    }

    void Update()
    {
        if (isWaiting) return;
        animator.SetFloat("speed", 2);
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.y < deathY || speed < 5)
        {
            Respawn();
        }

        void Respawn()
        {
            speed = 0;
            animator.SetFloat("speed", 0);
            transform.position = new Vector3(-14.05f, -1.28f, 0);
           
        }


    }
}
