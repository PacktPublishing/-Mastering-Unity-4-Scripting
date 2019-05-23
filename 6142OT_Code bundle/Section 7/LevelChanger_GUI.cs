using UnityEngine;
using System.Collections;

public class LevelChanger_GUI : MonoBehaviour 
{
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/2, Screen.height/2, 100, 30), "Change Level"))
		{
			if(Application.loadedLevel == 0)
				Application.LoadLevel(1);
			
			if(Application.loadedLevel == 1)
				Application.LoadLevel(0);
		}
	}
}
