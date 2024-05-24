using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Stats")]
public class Stats : ScriptableObject {
    public string playerName;

    public int health;
    public int maxHealth;

    public int mana;
    public int maxMana;

    public int level;

    public Vector2[] location;

    //abilities
    public bool shield;
    public bool rockThrow;
    public bool groundSlam;

    public bool dash;
    public bool airBlast;
    public bool slowFall;

    public bool fireSword;
    public bool fireBall;
    public bool lightOrb;

    public bool waterJet;
    public bool iceKnives;
    public bool freeze;

}

