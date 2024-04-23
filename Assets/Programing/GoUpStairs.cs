using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoUpStairs : MonoBehaviour
{
    private Player player;
    public int Range1;
    public int Range2;
    void goupStairs()
    {
       player.currentHealth = 1;

        int index = Random.Range(Range1, Range2);
        SceneManager.LoadScene(index);
        DontDestroyOnLoad(player);
        Debug.Log("Scene Loaded");
    }
}
