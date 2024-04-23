using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneral : MonoBehaviour
{
    [SerializeField] Player player; // Change the type to Player
    [SerializeField] int HP;
    [SerializeField] int damage;
    [SerializeField] int hitChance;
    public bool isAlive = true;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    // Function to roll a six-sided die
    int RollD6()
    {
        // Random.Range generates a random float between min (inclusive) and max (exclusive)
        // Mathf.FloorToInt rounds the float down to the nearest integer
        return Mathf.FloorToInt(Random.Range(1f, 7f));
    }

    public void DealDamage()
    {
        if (isAlive == true)
        {
            if (hitChance >= RollD6())
            {
                player.takeDamage(damage);
            }
            else
            {
                //miss
            }
        }
    }
    public void DealCritDamage()
    {
        if (isAlive == true)
        {
            if (hitChance >= RollD6())
            {
                player.takeDamage(damage * 2);
            }
            else
            {
                //miss
            }
        }
    }

    public void takeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
            dies();
    }

    void dies()
    {
        isAlive = false;
        Destroy(gameObject);
    }
}