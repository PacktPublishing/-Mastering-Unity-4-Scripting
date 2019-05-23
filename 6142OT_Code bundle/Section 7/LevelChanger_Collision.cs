using UnityEngine;
using System.Collections;

public class LevelChanger_Collision : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "LevelChanger")
		{
			Application.LoadLevel("LevelChange_1a");
		}
	}
}
