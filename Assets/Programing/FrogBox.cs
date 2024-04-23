using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogBox : MonoBehaviour
{
    
    Player player;

    void Start()
    {
        void Kiss()
        {
            player.currentHealth = player.currentHealth += 5;
            player.healthBar.SetHealth(player.currentHealth);
        }

        void Fight()
        {
            SceneManager.LoadScene(0);//insert double dmg toad scene
        }
    }

}

