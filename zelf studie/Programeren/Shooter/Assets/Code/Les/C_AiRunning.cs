using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class C_AiRunning : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask watGroud, watPlayer;


    //patrroling 
    public Vector3 walkpoint;
    public bool walkpointset;
    public float walkingRange;


    //stats
    public float SightRange, AttackRange;
    public bool playerInSifght, playerInAttack;


    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

	private void Update()
	{
        playerInSifght = Physics.CheckSphere(transform.position, SightRange, watPlayer);
        playerInAttack = Physics.CheckSphere(transform.position, AttackRange, watPlayer);


        if (!playerInSifght && !playerInAttack) patroling();
        if (playerInSifght && playerInAttack) running();
    }
	void patroling() 
    {
        if (!walkpointset) SearchingWalkingPoint();

        if (walkpointset)
            agent.SetDestination(walkpoint);

        Vector3 distansetowalkpoint = transform.position - walkpoint;


        //walkingpoint reacht
        if (distansetowalkpoint.magnitude < 1f)
            walkpointset = false;
    }

    void SearchingWalkingPoint()
    {
        float randomz = Random.Range(-walkingRange, walkingRange);
        float randomx = Random.Range(-walkingRange, walkingRange);

        walkpoint = new Vector3(transform.position.x + randomx, transform.position.y + randomz, transform.position.z + randomx);

        if (Physics.Raycast(walkpoint, -transform.up, 2f, watGroud))
            walkpointset = true;
    }

    void running()
    {
        agent.SetDestination(player.position);
    }
}
