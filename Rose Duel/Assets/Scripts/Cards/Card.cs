using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Card : ScriptableObject
{
    [Header("Card Attributes")]
    [SerializeField] public long card_ID;
    [SerializeField]public string card_name;

    [TextArea(1, 30)]
    [SerializeField] public string card_description;
    [SerializeField] public int card_cost;
    [SerializeField] public int Speed = 1;
    [SerializeField] public string[] card_tags = new string[5];


    [Header("Card States")]
    [SerializeField] public bool face_up;
    [SerializeField] public bool attack_position;
    [SerializeField] public bool movedThisTurn;
    [SerializeField] public bool attackedThisTurn;

    [Header("Card References")]
    [SerializeField] public Sprite card_image;
    [SerializeField] public string card_artist;
    [SerializeField] public CardEffect[] Card_Effects = new CardEffect[2];
    public void ApplyEffect()
    {

    }

}
