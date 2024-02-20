using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class food : MonoBehaviour
{
    private Camera cam;
    public GameObject foodPrefab;
    public UnityEvent onFoodSpawned;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        if (onFoodSpawned == null)
            onFoodSpawned = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnFood();
        }
        
    }
    void SpawnFood()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

        worldPos.z = 0;

        Instantiate(foodPrefab, worldPos, Quaternion.identity);
        onFoodSpawned.Invoke();
    }
}
