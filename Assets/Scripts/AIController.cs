using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public float attackRange = 2f; // Range at which AI attacks
    public float attackCooldown = 1f; // Cooldown between attacks

    private bool isTagged = false;
    private float nextAttackTime = 0f;
    private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        // Initialize the player reference (you can do this in the Inspector)
        // player = GameObject.FindGameObjectWithTag("Player").transform;
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
                    // Check if it's time to attack
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
        navMeshAgent.ResetPath(); // Stop AI navigation when tagged
    }

    private void Attack()
    {
        // Implement your attack logic here
        // For example, you can decrease the player's health or perform other actions
        // Replace this with your desired attack behavior
        Debug.Log("Attacking player!");
    }
}
