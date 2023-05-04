using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject goalDestination;
    public float speedWalk = 6;

    void Start()
    {
        navMeshAgent.speed = speedWalk; //  velocidad a la que se desplaza.
    }

    void Move(float speed)
    {
        navMeshAgent.isStopped = false;
        navMeshAgent.speed = speed;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //  cambia el destino del player con hacer click en el mesh.
        {
            RaycastHit hit;
            Move(speedWalk);
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                navMeshAgent.destination = hit.point;
            }
        }
        
    }
}
