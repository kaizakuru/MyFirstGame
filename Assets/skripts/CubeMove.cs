using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rigidbody;
    private void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(move * speed, rigidbody.velocity.y);
        
    }

}
