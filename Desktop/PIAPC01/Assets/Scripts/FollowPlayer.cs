using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public GameObject player;

    void Start()
    {
        //hace que el destino sea el objeto destination.
        navMeshAgent.destination = player.transform.position;
    }
    private void Update()
    {
        navMeshAgent.destination = player.transform.position;
    }
}
