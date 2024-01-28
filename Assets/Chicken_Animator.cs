using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken_Animator : MonoBehaviour
{
    NavMeshAgent _navAgent;
    [SerializeField]
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponentInChildren<Animator>();
        //_animator = GetComponentIn<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_animator != null) { Debug.Log("Animator is being updated!"); }
        //Debug.Log("Chicken Speed: " + _navAgent.velocity.magnitude);
        _animator.SetFloat("MotionSpeed", _navAgent.velocity.magnitude);
    }
}
