using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 15;
    public int currentHealth;

    public int Potions = 5;
    public Weapon PlayerWeapon;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        //Checks so health does not exced max health.
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0 && SceneManager.GetActiveScene().buildIndex != 2)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
            Debug.Log("Scene Loaded");
        }

    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void Heal()
    {
        //Checks if you have postions.
        if (Potions != 0)
        {
            currentHealth += 5;
            Potions--;

            healthBar.SetHealth(currentHealth);
        }
        else
        {
            //No potions left
        }

    }

}