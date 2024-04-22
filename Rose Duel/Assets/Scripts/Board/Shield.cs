using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
 
    private Hand hand;
    private Deck deck;
    private DiscardPile discardPile;
    private ExtraDeck extraDeck;

    private void Start()
    {
        hand = this.GetComponent<Hand>();
        deck = this.GetComponent<Deck>();
        discardPile = this.GetComponent<DiscardPile>();
        extraDeck = this.GetComponent<ExtraDeck>();

    }
    public List<Card> GetCards()
    {
        return cards;
    }
    public void ShuffleShield()
    {
        cards.Shuffle();//Uses the shuffle method created in the ListExtensions script. (Fisher-Yates shuffle algorithm)
    }

    public void AddToShield(Card card)
    {
        cards.Add(card);
        ShuffleShield();
    }

    public void DrawFromShield()
    {//Move a card from shield to your hand, and gain 1 energy
        //AKA Taking damage

        if (cards.Count > 0)
        {
            hand.AddCardToHand(cards[0]);
            cards.Remove(cards[0]);
        }
        else
        {
            Debug.Log("The shield is empty and your Deck Leader is attacked, you lose the game.");
            Debug.Log("Otherwise nothing happened");
        }
    }


    //*****************************************************************************
    //These methods move cards from the Shield to their respective destination

    public void ToHand(Card card)
    {
        if (cards.Contains(card))
        {
            hand.AddCardToHand(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in your Shield, the effect fizzles");
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
            Debug.Log("This card does not exist in your Shield, the effect fizzles");
        }
    }
    public void ToDiscardPile(Card card)
    {
        if (cards.Contains(card))
        {
            discardPile.AddToDiscard(card);
            cards.Remove(card);
        }
        else
        {
            Debug.Log("This card does not exist in your Shield, the effect fizzles");
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
            Debug.Log("This card does not exist in your Shield, the effect fizzles");
        }
    }
    //*****************************************************************************
}
