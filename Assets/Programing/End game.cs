using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Scene Loaded");
    }
}
