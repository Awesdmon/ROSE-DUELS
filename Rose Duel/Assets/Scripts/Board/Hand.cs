using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private List<Card> cards;

    private Deck deck;
    private DiscardPile discardPile;
    private Shield shield;

    private void Start()
    {
        deck = this.GetComponent<Deck>();
        discardPile = this.GetComponent<DiscardPile>();
        shield = this.GetComponent<Shield>();
    }

    public void AddCardToHand(Card card)
    {//Adds a specific card
        cards.Add(card);
    }

    public void PlayCard(Card card) 
    {
        //This should be moved from hand to the board
    }

    //*****************************************************************************
    //These methods move cards from the Hand to their respective destination
    public void ToDeck(Card card)
    {
        if (cards.Contains(card))
        {
            deck.AddCardToDeck(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in your hand, the effect fizzles");
        }

    }
    public void ToDiscard(Card card)
    {
        if (cards.Contains(card))
        {
            discardPile.AddToDiscard(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in your hand, the effect fizzles");
        }

    }
    public void ToShield(Card card)
    {
        if (cards.Contains(card))
        {
            shield.AddToShield(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in your hand, the effect fizzles");
        }
    }

    //*****************************************************************************
}
