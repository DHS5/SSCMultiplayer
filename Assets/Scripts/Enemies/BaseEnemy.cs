using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

public abstract class BaseEnemy : MonoBehaviour
{
    #region Global Members

    [Header("Base Enemy")]
    [SerializeField] protected NavMeshAgent _agent;

    #endregion

    #region Movements

    protected void SetDestination(Vector3 destination)
    {
        _agent.destination = destination;
    }

    #endregion
}
