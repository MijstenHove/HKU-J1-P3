using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_LesState : MonoBehaviour
{
    public int i;
    public enum StateEnum { Idle, Atteck, Walk, Jump };
    public StateEnum state;

	public void Update()
	{
        CheckState();

    }


	private void CheckState() 
    {

        switch (state) 
        {
            case StateEnum.Idle: IdleBehaviour(); break;
            case StateEnum.Atteck: AtteckBehaviour(); break;
            case StateEnum.Walk: WalkBehaviour(); break;
            case StateEnum.Jump: JumpBehaviour(); break;



        }
    
    }

    void IdleBehaviour()
    { 
        print("idel"); 
    }
    void AtteckBehaviour()
    {
        print("atteck"); 
    }
    void WalkBehaviour()
    {
        print("walk"); 
    }
    void JumpBehaviour()
    {
        print("jump"); 
    }
}
