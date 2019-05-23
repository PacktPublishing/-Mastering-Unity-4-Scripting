using UnityEngine;
using System.Collections;

public enum eState1 {idle, patrol, attack, die};

public class Enemy_AnimState_Controller : MonoBehaviour 
{
	public eState1 STATE = eState1.idle;
	public Animation _Animation;
	public AnimationClip aIdle;
	public AnimationClip aPatrol;
	public AnimationClip aAttack;
	public AnimationClip aDie;
	public float oIdle = 1f;
	public float oPatrol = 1f;
	public float oAttack = 1f;
	public float oDie = 1f;
	
	void Update()
	{
		CheckState();
	}
	
	void SetState(eState1 myState)
	{
		STATE = myState;
	}
	
	void CheckState()
	{
		switch(STATE)
		{
			case eState1.attack:
				gameObject.SendMessage("sAttack");
				_Animation[aAttack.name].speed = oAttack;
				_Animation.wrapMode = WrapMode.Loop;
				_Animation.CrossFade(aAttack.name);
			break;
			case eState1.die:
				gameObject.SendMessage("sDie");
				_Animation[aDie.name].speed = oDie;
				_Animation.wrapMode = WrapMode.ClampForever;
				_Animation.CrossFade(aDie.name);
			break;
			case eState1.idle:
				gameObject.SendMessage("sIdle");
				_Animation[aIdle.name].speed = oIdle;
				_Animation.wrapMode = WrapMode.Loop;
				_Animation.CrossFade(aIdle.name);
			break;
			case eState1.patrol:
				gameObject.SendMessage("sPatrol");
				_Animation[aPatrol.name].speed = oPatrol;
				_Animation.wrapMode = WrapMode.Loop;
				_Animation.CrossFade(aPatrol.name);
			break;
		}
	}
}
