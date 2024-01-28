using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public UnityEvent escapeEvent;

    PauseScreen pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null) { Destroy(this); }
        if (instance == null) { instance = this; }
        //This will always be available!
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //TODO: Pause logic?
            escapeEvent.Invoke();
        }
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        if (levelIndex == 0) AudioManager.instance.OneShotBawk();
    }

    public void QuitGame()
    {
        AudioManager.instance.OneShotBawk();
        Application.Quit();
    }
}
