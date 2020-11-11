using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int hp = 100;

    public Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D.AddForce(new Vector2(0, -10));
    }

    private void Update()
    {
        if (hp <= 0)
        {
            Debug.Log("Player has died");

            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp -= 10;
    }
}
