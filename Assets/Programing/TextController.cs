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
        // när man trycker på en knapp så ska gammal text försvinna och ny text komma fram.
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
