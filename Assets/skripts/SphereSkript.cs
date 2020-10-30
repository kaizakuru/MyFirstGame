using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereSkript : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public Text textshow ;
    public int score;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
       
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            rigidbody.velocity = new Vector2(Random.Range(-4f, 4f), rigidbody.velocity.y);
            score++;
            textshow.text = score.ToString();
        }
    }
}
