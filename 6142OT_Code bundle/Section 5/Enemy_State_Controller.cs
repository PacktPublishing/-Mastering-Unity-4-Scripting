using UnityEngine;
using System.Collections;

public enum eState {idle, patrol, attack, die};

public class Enemy_State_Controller : MonoBehaviour 
{
	public eState STATE = eState.idle;
	
	void Update()
	{
		CheckState();
	}
	
	void SetState(eState myState)
	{
		STATE = myState;
	}
	
	void CheckState()
	{
		switch(STATE)
		{
			case eState.attack:
				gameObject.SendMessage("sAttack");
				Debug.Log("ATTACK");
			break;
			case eState.die:
				gameObject.SendMessage("sDie");
				Debug.Log("DIE");
			break;
			case eState.idle:
				gameObject.SendMessage("sIdle");
				Debug.Log("IDLE");
			break;
			case eState.patrol:
				gameObject.SendMessage("sPatrol");
				Debug.Log("PATROL");
			break;
		}
	}
}