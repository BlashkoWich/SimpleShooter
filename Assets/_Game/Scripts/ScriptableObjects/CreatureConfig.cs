using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreatureConfig", menuName = "Config/Game/CreatureConfig")]
public class CreatureConfig : ScriptableObject
{
    public CreatureStats creatureStats;
}
[System.Serializable]
public struct CreatureStats
{
    public int health;
    public int damage;
    public float speed;
}
