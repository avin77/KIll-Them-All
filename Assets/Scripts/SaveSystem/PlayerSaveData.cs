using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Rendering;

[System.Serializable]
public class PlayerSaveData
{
	public int level;
	public float expPoints;
	public WeaponData currentWeapon;
	public List<ArmorData> currentArmor;
}
