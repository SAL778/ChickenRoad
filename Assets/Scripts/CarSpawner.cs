using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> cars;
    [SerializeField]
    float moveSpeed = 1f;
    [SerializeField]
    float spawnRate = 3f;
    [SerializeField]
    float spawnStartDelay = 0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCar", spawnStartDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCar() {
        if (cars != null && cars.Count > 0)
        {
            GameObject newCar = Instantiate(cars[Random.Range(0, cars.Count)]);
            newCar.transform.position = transform.position;
            newCar.transform.rotation = transform.rotation;
        } else
        {
            Debug.Log("No Cars in spawner: " + name);
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(transform.position, direction);
    }
}
