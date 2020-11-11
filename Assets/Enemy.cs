using UnityEngine;
using System.Collections;

public class Enemy
{
    public int hitpoints, damage;
    
    string name;

    bool hasDied;

    public Enemy(int hp, int dmg, string ID)
    { 
        hitpoints = hp; 
        damage = dmg; 
        name = ID;
    }

    public void TakeDamage()
    {
        if (!hasDied)
        {
            hitpoints--;
            Debug.Log(name + "'s HP: " + hitpoints);
        }
    }

    public void Die()
    {
        if (!hasDied)
        {
            Debug.Log(name + " Has Died");
            hasDied = true;
        }
    }
}
