using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TerraGaia {

    [CreateAssetMenu( fileName = "New Ability", menuName = "Skill/Ability" )]
    public class AbilityManager : ScriptableObject
{   
    public new string name;
    public int id;
    public Sprite sprite;
    public Element element;

    [SerializeField]
    private string description;
    [SerializeField]
    private int manaCost;
    [SerializeField]
    private int staminaCost;

    /*
    public bool enableArcaneDefense
    {
        get {return this.hasArcaneDefense;}
        set {this.hasArcaneDefense = value;}
    }

    public bool enableArcaneStrike
    {
        get {return this.hasArcaneStrike;}
        set {this.hasArcaneStrike = value;}
    }
    */

    public bool hasAdrenaline = false; 
    public bool hasArcaneDefense = false; 
    public bool hasArcaneStrike = false; 
    public bool hasBackstab = false; 
    public bool hasBeastmaster = false; 
    public bool hasBond = false; 
    public bool hasBlast = false; 
    public bool hasCelerity = false; 
    public bool hasCleave = false; 
    public bool hasCriticalFocus = false; 
    public bool hasDeathwatch = false; 
    public bool hasDiehard = false; 
    public bool hasDuelWield = false; 
    public bool hasDyingWish = false; 
    public bool hasExoskeleton = false; 
    public bool hasFearless = false; 
    public bool hasFirststrike = false; 
    public bool hasFlying = false; 
    public bool hasForcefield = false; 
    public bool hasFrenzy = false; 
    public bool hasHalfMana = false; 
    public bool hasHardened = false; 
    public bool hasHeadStrong = false; 
    public bool hasIgnoreEvelation = false; 
    public bool hasImmune = false; 
    public bool hasInfiltrate = false; 
    public bool hasInvulnerable = false; 
    public bool hasJump1 = false; 
    public bool hasJump2 = false; 
    public bool hasJump3 = false; 
    public bool hasLifefoot = false; 
    public bool hasLifesteal = false; 
    public bool hasMagicCounter = false; 
    public bool hasManaSap = false; 
    public bool hasManaFoot = false; 
    public bool hasManaShield = false; 
    public bool hasManaRegen = false; 
    public bool hasMove1 = false; 
    public bool hasMove2 = false; 
    public bool hasMove3 = false; 
    public bool hasParry = false; 
    public bool hasPoach = false; 
    public bool hasProvoke = false; 
    public bool hasRanged = false; 
    public bool hasRebirth = false; 
    public bool hasRegen  = false; 
    public bool hasRetreat = false; 
    public bool hasRush = false; 
    public bool hasSoulsplit = false; 
    public bool hasStun = false; 
    public bool hasTeleport = false; 
    public bool hasTwinstrike = false; 
    public bool hasSwimming = false; 
    public bool hasWaterWalking = false; 
    public bool hasZeal = false; 
    public bool hasWhirlwind = false;
    
    
    }
}
