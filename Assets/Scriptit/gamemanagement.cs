﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanagement : MonoBehaviour {

    [Header("World")]
    public int timeOfDay;
    [Header("__________________________")]
    //lists / arrays I dont fucking know
    [Range(1,20)]
    public int CurrentPetInt;
    public Monsters[] AllMonsters;
    public Buffs[] buffs;
    public Items[] AllItems;
    public houses[] enterableBuildings;

	void Start () {
        Cursor.visible = false;
	}
	void Update () {
		
	}
}
[System.Serializable]
public class Monsters
{
    public string name, description;
    public int strength, agility, wisdom , luck;    //upgradable stats
    public int health, hunger, happyness, cleaniness;    //beauty
}
[System.Serializable]
public class Buffs
{
    public string name, description;
    public int buffPropertyInt;
    public bool buffBool;
}
[System.Serializable]
public class Items
{
    public string name, description;
    public int itemPropertyInt;
    public Sprite itemImage;
}
[System.Serializable]
public class houses
{
    public string name;
    public int sceneIndex;
    public Vector3 locationOnMap;
}