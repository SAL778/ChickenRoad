using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


/// <summary>
/// Cars spawn and move across the screen. When out of view, they de-spawn.
/// </summary>
[RequireComponent(typeof(BoxCollider))]
public class Car : MonoBehaviour
{
    public float moveSpeed = 1f;
    public int length = 2;

    bool carWasVisible;

    MeshRenderer meshRenderer;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position += transform.forward * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position += transform.forward * moveSpeed * Time.deltaTime);
        //Debug.Log("Car has lived!");
    }

    private void LateUpdate()
    {
        //Debug.Log("Car is visible? " + meshRenderer.isVisible);
        //This check prevents the car from being despawned if it spawned off screen.
        if(!carWasVisible)
        {
            if(meshRenderer.isVisible) carWasVisible = true;
        } else
        {
            if (!GetComponent<MeshRenderer>().isVisible) Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If we want the car to do anyting when it hits something... this is the place we'd put that code.
        Debug.Log("Car " + name + " hit something!");
    }
}
