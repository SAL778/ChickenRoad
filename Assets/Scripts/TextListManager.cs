using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextListManager : MonoBehaviour
{
    public static TextListManager Instance; 
    public List<string> textList = new List<string>();
    public List<string> unhingedTextList = new List<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(this);
        }
    }
}
