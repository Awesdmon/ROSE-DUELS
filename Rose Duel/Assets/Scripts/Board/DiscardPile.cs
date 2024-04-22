using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    private Hand hand;
    private Deck deck;
    private Shield shield;
    private ExtraDeck extraDeck;

    private void Start()
    {
        hand = this.GetComponent<Hand>();
        deck = this.GetComponent<Deck>();
        shield = this.GetComponent<Shield>();
        extraDeck = this.GetComponent<ExtraDeck>();
    }
    public List<Card> GetCards()
    {
        return cards;
    }
    public void AddToDiscard(Card card)
    {
        cards.Add(card);
    }

    public void PlayCard(Card card)
    {
        
    }

    //*****************************************************************************
    //These methods move cards from the discard pile to their respective destination
    public void ToHand(Card card)
    {
        if (cards.Contains(card))
        {
            hand.AddCardToHand(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in the discard pile, the effect fizzles");
        }
    }

    public void ToDeck(Card card)
    {
        if (cards.Contains(card))
        {
            deck.AddCardToDeck(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in the discard pile, the effect fizzles");
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
            Debug.Log("This card does not exist in the discard pile, the effect fizzles");
        }
    }

    public void ToExtraDeck(Card card)
    {
        if (cards.Contains(card))
        {
            extraDeck.AddToExtraDeck(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in the discard pile, the effect fizzles");
        }
    }
    //*****************************************************************************
}
