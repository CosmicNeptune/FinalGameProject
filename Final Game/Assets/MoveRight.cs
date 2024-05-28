using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 5f;

    public float targetYPosition = -4f;
   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
        if(Mathf.Approximately(transform.position.y, targetYPosition))
        {
            Destroy(gameObject);
        }
    }
}
