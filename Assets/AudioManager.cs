using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource audioSource;

    [SerializeField]
    AudioClip chickenBawk;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        audioSource.PlayOneShot(chickenBawk);
        DontDestroyOnLoad(this);   
    }

    public void OneShotBawk()
    {
        
    }
}
