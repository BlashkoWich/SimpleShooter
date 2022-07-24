using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [SerializeField]
    private CreatureConfig _creatureConfig;
    [HideInInspector]
    public CreatureStats stats;
}
