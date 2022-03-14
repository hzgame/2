using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent _navmeshagent;
    private Animator _animator;

    private void Start()
    {
        _navmeshagent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        MouseManager.Instance.OnMouseClicked += MovetoTarget;
    }

    private void FixedUpdate()
    {
        ChangeAnimation();
    }
    private void ChangeAnimation()
    {
        _animator.SetFloat("speed", _navmeshagent.velocity.sqrMagnitude);
    }//改变动画

    public void MovetoTarget(Vector3 target)
    {
        _navmeshagent.destination = target;
    }//移动至目的地
}
