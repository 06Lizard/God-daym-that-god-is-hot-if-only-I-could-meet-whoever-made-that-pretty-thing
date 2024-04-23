using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossFight : MonoBehaviour
{
    private Player player;
    private GameObject player1;

    public void bossFight()
    {
        SceneManager.LoadScene(16);
        DontDestroyOnLoad(player);
        Debug.Log("Scene Loaded");
    }
}
