using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Riddlesbuttons : MonoBehaviour
{
    private Player player;
    private GameObject player1;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    public void Wrong()
    {
        player.currentHealth = 0;
        Debug.Log("YEY");
        SceneManager.LoadScene(0);
    }

    public void Right()
    {
        player.currentHealth = player.maxHealth;

        
        SceneManager.LoadScene(5);
        DontDestroyOnLoad(player);
        Debug.Log("Scene Loaded");
    }
}
