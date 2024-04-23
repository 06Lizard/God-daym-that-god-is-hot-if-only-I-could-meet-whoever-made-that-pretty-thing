using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gordon : MonoBehaviour
{

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        
        int getShot = Random.Range(0, 10);
        if (getShot == 1)
        {
            player.currentHealth = 1;
            player.healthBar.SetHealth(player.currentHealth);
        }
    }
}
