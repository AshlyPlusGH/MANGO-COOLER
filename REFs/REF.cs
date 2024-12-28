using UnityEngine;
using System;
using System.Collections.Generic;

class Logo{

}

/// <summary>
/// 
/// </summary>

class Faction{
    public string name = "My Faction";
    public Logo logo;
    public FactionGoal factionGoal;
    public Religion factionReligion = null;
    public Leader factionLeader = null;
    public List<HoldingType> primaryHoldingTypes = new List<HoldingType>(){};
}

enum FactionGoal{
    Imperialism,
    Habitation,
    Exosolar
}

enum FactionType{
    Nation,
    Company,
    Collective,
    Idealogue
}

class Religion{
    public string name;
}

/// <summary>
/// 
/// </summary>

class Leader{
    public string name;
    public int age;
    public Gender gender = Gender.Female;
    public Religion religion;
}

enum Gender{
    Male,
    Female,
    AttackHelicopter
}

/// <summary>
/// 
/// </summary>

class Holding{
    public string name;
    public HoldingType type;
}

enum HoldingType{
    Capital,
    Deposit,
    Region,
    Facility,
    Route,
    Oddity,
}