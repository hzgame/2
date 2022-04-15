using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoatController : MonoBehaviour
{
    private NavMeshAgent _navmeshagent;

    private void Start()
    {
        _navmeshagent = GetComponent<NavMeshAgent>();
        MouseManager.Instance.OnMouseClicked_Boat += MovetoTarget;
    }
    public void MovetoTarget(Vector3 target)
    {
        _navmeshagent.destination = target;
    }//移动至目的地
}
