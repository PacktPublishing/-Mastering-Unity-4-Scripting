using UnityEngine;
using System.Collections;

public enum Weapon{Staff, Sword, Axe}

public class InventoryPrefs : MonoBehaviour 
{
	#region Video One - Create the Prefs
	public Weapon iWeapon = Weapon.Staff;
	public string WeaponName; // Wooden Staff, Iron Sword, Steel Axe
	public int Gold; // 10, 20, 40
	public float Damage; // 15, 30, 60
	#endregion
	
	#region Video Two - Save the Prefs
	void SavePrefs()
	{
		switch(iWeapon)
		{
		case Weapon.Staff:
			WeaponName = "Wooden Staff";
			Gold = 10;
			Damage = 15f;
			break;
		case Weapon.Sword:
			WeaponName = "Iron Sword";
			Gold = 20;
			Damage = 30f;
			break;
		case Weapon.Axe:
			WeaponName = "Steel Axe";
			Gold = 40;
			Damage = 60f;
			break;
		}
		
		PlayerPrefs.SetFloat("ppDamage", Damage);
		PlayerPrefs.SetInt("ppGold", Gold);
		PlayerPrefs.SetString("ppWeaponName", WeaponName);
	}
	#endregion
	
	#region Video Three - Load and Test the Prefs
	void LoadPrefs()
	{
		WeaponName = PlayerPrefs.GetString("ppWeaponName");
		Gold = PlayerPrefs.GetInt("ppGold");
		Damage = PlayerPrefs.GetFloat("ppDamage");
		
		switch(WeaponName)
		{
		case "Wooden Staff":
			iWeapon = Weapon.Staff;
			break;
		case "Iron Sword":
			iWeapon = Weapon.Sword;
			break;
		case "Steel Axe":
			iWeapon = Weapon.Axe;
			break;
		}
	}
	
	void Update()
	{
		if(Input.GetKey(KeyCode.S))
			SavePrefs();
		
		if(Input.GetKey(KeyCode.L))
			LoadPrefs();
	}
	#endregion
}