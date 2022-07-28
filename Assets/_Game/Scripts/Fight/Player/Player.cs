using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Creature
{
    [SerializeField]
    private Transform _rotator;
    public Transform Rotator => _rotator;
}
