using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum StateEnum { Idle, Run, Walk, Search };

public class C_LesState : MonoBehaviour
{
    // control rr voor dyslct fouten 

    private NavMeshAgent enemy;
    private Transform enemyplayer;

    public Transform[] waypoint;
    public float playerDistance;
    public float running;
    float timer = 3;

    private Transform targetWayPoint;
    [SerializeField] private Transform currendWaPoint;

    [SerializeField] private StateEnum state;

    public void Start()
	{
        enemyplayer = GetComponent<Transform>();
        enemy = GetComponent<NavMeshAgent>();
	}


	public void Update()
	{
        if (waypoint.Length == 0)
        {
            Debug.LogError("set waypoints in list");
      
        }
        else
            currendWaPoint = waypoint[0];

        CheckState();
    }
     void CheckState() 
    {

        switch (state) 
        {
            case StateEnum.Idle: IdleBehaviour(); break;
            case StateEnum.Run: RunningBehaviour(); break;
            case StateEnum.Walk: WalkBehaviour(); break;
            case StateEnum.Search: SearchBehaviour(); break;
        }
    
    }

    void IdleBehaviour()
    { 
        print("idel");
        timer -= Time.deltaTime;
        if (timer < 0) 
        {
            SwitchState(StateEnum.Walk);
        }
     
            // is stil aan het staan voor een bepaalde hoeveelhijd tijd 
    }
    void RunningBehaviour()
    {
        print("atteck");
        // is aan het wergrennen voor de player 
    }
    void WalkBehaviour()
    {
       // if (Vector3.Distance(transform.position, enemyplayer.position) < running)
       // {
       //     enemy.destination = targetWayPoint.position;
       // }
        print("walk");
        // is opweg naar de plak van seurtch 
    }
    void SearchBehaviour()
    {
        print("jump"); 
       //kijk naar waar hij naartoe moet 
    }

    void SwitchState(StateEnum newState)
    {
        switch (newState)
        {
            case StateEnum.Idle:
                break;
            case StateEnum.Run:
                break;
            case StateEnum.Walk:
                break;
            case StateEnum.Search:
                break;
        }

        state = newState;
    }
}
