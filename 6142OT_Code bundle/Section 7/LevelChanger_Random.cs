using UnityEngine;
using System.Collections;

public class LevelChanger_Random : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetButtonUp("Jump"))
		{
			Application.LoadLevel(Random.Range(0,6));
		}
		
		Debug.Log(Application.loadedLevel.ToString());
	}
}
