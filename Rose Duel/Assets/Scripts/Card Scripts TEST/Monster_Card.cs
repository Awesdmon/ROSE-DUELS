using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Monster", menuName = "Cards/Monster")]
public class Monster_Card : Card
{
    [Header("Monster Attributes")]
    [SerializeField] public int Attack;
    [SerializeField] public int Defense;
    //public override void Card_Effect() { }

    public new void ApplyEffect()
    {

    }
}
