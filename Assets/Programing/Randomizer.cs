using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Randomizer : MonoBehaviour
{
    public Player player;

    public int Range1;
    public int Range2;
    public void RandomScene()
    {
        int index = Random.Range(Range1, Range2);
        SceneManager.LoadScene(index);
        DontDestroyOnLoad(player);
        Debug.Log("Scene Loaded");
    }

}
