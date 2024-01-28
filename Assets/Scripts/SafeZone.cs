using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null && collision.gameObject.name == "Chicken") { LevelManager.instance.LoadLevel("GAME_WIN"); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.gameObject.name == "Chicken") { LevelManager.instance.LoadLevel("GAME_WIN"); }
    }
}
