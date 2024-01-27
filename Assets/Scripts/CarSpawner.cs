using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> cars;
    /// <summary>
    /// Minimum move speed for the cars
    /// </summary>
    [SerializeField]
    float moveSpeed = 1f;
    /// <summary>
    /// Randomizes move speeds. This may be unfair to the player.
    /// </summary>
    [SerializeField]
    bool randomMoveSpeed = false;
    /// <summary>
    /// Maximum move speed for the cars
    /// </summary>
    float maxMoveSpeed = 2f;
    /// <summary>
    /// How many seconds between spawns.
    /// </summary>
    [SerializeField]
    float spawnRate = 3f;
    /// <summary>
    /// Delay the first car spawn for x seconds.
    /// </summary>
    [SerializeField]
    float spawnStartDelay = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //Basic, repeating car spawn. Constant pattern, no variation.
        InvokeRepeating("SpawnCar", spawnStartDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Spawns a car at the position of the spawner, facing the same direction.
    /// </summary>
    void SpawnCar() {
        if (cars != null && cars.Count > 0)
        {
            GameObject newCar = Instantiate(cars[Random.Range(0, cars.Count)]);
            newCar.transform.position = transform.position;
            newCar.transform.rotation = transform.rotation;
            if(randomMoveSpeed)
            {
                newCar.GetComponent<Car>().moveSpeed = Random.Range(moveSpeed,maxMoveSpeed);
            } else
            {
                newCar.GetComponent<Car>().moveSpeed = moveSpeed;
            }
        } else
        {
            Debug.Log("No Cars in spawner: " + name);
        }
    }

    /// <summary>
    /// Draws a red line that indicates the direction the cars will face when spawned.
    /// </summary>
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(transform.position, direction);
    }
}
