using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text textToRemove;
    public Text textToAppear;

    void Start()
    {
        
    }

    void Update()
    {
        // n�r man trycker p� en knapp s� ska gammal text f�rsvinna och ny text komma fram.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RemoveText();
            ShowText();
        }
    }

    void RemoveText()
    {
        textToRemove.gameObject.SetActive(false);
    }

    void ShowText()
    {
        textToAppear.gameObject.SetActive(true);
    }
}
