using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DrawCard", menuName = "Effect/DrawCard")]
public class DrawCard : CardEffect
{
    /*
     * Testing CardEffects. 
     * 
     * Cards with this effect should draw an amount of cards
     */

    [SerializeField] int num_cards;
    public override void ApplyEffect()
    {
        Debug.Log("Draw " + num_cards + " cards");
    }
}
