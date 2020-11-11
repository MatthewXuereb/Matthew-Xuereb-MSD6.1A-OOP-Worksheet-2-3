using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    Enemy bob, alice;

    int playerHP = 10;

    bool hasDied;

    void Start()
    {
        bob = new Enemy(5, 2, "Bob");
        alice = new Enemy(2, 5, "Alice");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bob.TakeDamage();
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            alice.TakeDamage();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!hasDied)
            {
                playerHP -= bob.damage;
                Debug.Log("Player HP: " + playerHP);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if (!hasDied)
            {
                playerHP -= alice.damage;
                Debug.Log("Player HP: " + playerHP);
            }
        }

        if (bob.hitpoints < 1)
        {
            bob.Die();
        }
        if (alice.hitpoints < 1)
        {
            alice.Die();
        }

        if (playerHP < 1)
        {
            if (!hasDied)
            {
                Debug.Log("You Died!");
                hasDied = true;
            }
        }
    }
}
