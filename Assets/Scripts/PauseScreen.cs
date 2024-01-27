using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.instance != null) LevelManager.instance.escapeEvent.AddListener(HidePauseScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HidePauseScreen()
    {
        gameObject.SetActive(false);
    }
}
