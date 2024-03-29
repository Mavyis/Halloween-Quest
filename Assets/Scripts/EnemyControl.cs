﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public float lookRadius = 10f;
    Animator anim;

    Transform target;
    NavMeshAgent agent;

    public float moveSpeed = 2f;



    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetInteger("Agora", 0);
    }

    
    void Update()
    {     

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);

            if(distance <= agent.stoppingDistance)
            {
                //atack
                FaceTarget();
                anim.SetInteger("Agora", 1);             
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 9f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
