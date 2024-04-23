using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel : MonoBehaviour
{
    Player player;
    void GainMaxHealth()
    {
        player.currentHealth = player.maxHealth;
        player.healthBar.SetHealth(player.currentHealth);
    }

    void GainPotions()
    {
        player.Potions = player.Potions += 2;
    }

}
