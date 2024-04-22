using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Deck Leader", menuName = "Cards/Deck_Leader")]
public class Deck_Leader_Card : Card
{
    /*
     * Deck Leaders are a type of card.
     * They cannot be changed to defense position.
     */
    [Header("Deck Leader Attributes")]
    [SerializeField] public int Attack;
    //public override void Card_Effect() { }

    public new void ApplyEffect()
    {

    }
}
