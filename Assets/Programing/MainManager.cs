using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instence;

    private void Awake2()
    {
        if (Instence != null)
        {
            Destroy(gameObject);
            return;
        }

        Instence = this;
        DontDestroyOnLoad(gameObject);
    }
}
