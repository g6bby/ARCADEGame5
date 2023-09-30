using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AIController : MonoBehaviour
{
    public Transform player; 
    public float attackRange = 2f;
    public float attackCooldown = 1f; 

    private bool isTagged = false;
    private float nextAttackTime = 0f;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if (!isTagged)
        {
            if (player != null)
            {
                navMeshAgent.SetDestination(player.position);

                if (Vector3.Distance(transform.position, player.position) <= attackRange)
                {
                    if (Time.time >= nextAttackTime)
                    {
                        Attack();
                        nextAttackTime = Time.time + attackCooldown;
                    }
                }
            }
        }
        else
        {
            // Handle behavior when the AI is tagged
        }
    }

    public void Tag()
    {
        isTagged = true;
        navMeshAgent.ResetPath(); 
    }

    private void Attack()
    {
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
