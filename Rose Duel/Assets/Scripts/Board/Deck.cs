using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    private Hand hand;
    private DiscardPile discardPile;
    private Shield shield;

    private void Start()
    {
        hand = this.GetComponent<Hand>();
        discardPile = this.GetComponent<DiscardPile>();
        shield = this.GetComponent<Shield>();
    }

    public List<Card> GetCards()
    {
        return cards;
    }

    public void ShuffleDeck()
    {
        cards.Shuffle();//Uses the shuffle method created in the ListExtensions script. (Fisher-Yates shuffle algorithm)
    }
    public void AddCardToDeck(Card card) 
    {
        //Adds a specific card to the deck
        cards.Add(card);
        ShuffleDeck();
    }
    public void PlayCard(Card card)
    {

    }
    //*****************************************************************************
    //These methods move cards from the top of the deck to their respective locations
    public void TopCardToHand()
    {//Drawing a card

        if (cards.Count > 0)
        {
            //Moves the top card of the deck to the hand
            hand.AddCardToHand(cards[0]);
            //Removes the top card of the deck
            cards.Remove(cards[0]);
        }
        else
        {
            //Drawing a card from an empty deck should cause the player to take damage.
            //shield.DrawFromShield();
            Debug.Log("Deck is empty, the effect should fizzle");
        }

    }

    public void TopCardToDiscard()
    {

        if (cards.Count > 0)
        {
            //Moves the top card from the deck to the discard pile
            discardPile.AddToDiscard(cards[0]);
            //Removes the first instance of the card from the deck
            cards.Remove(cards[0]);
        }
        else
        {
            Debug.Log("Deck is empty, the effect should fizzle");
        }
    }
    public void TopCardToShield()
    {//Move a card from the top of the deck to the shield
        if (cards.Count > 0)
        {
            //Adds the top card of the deck to the Shield
            shield.AddToShield(cards[0]);
            //Removes the top card of the deck
            cards.Remove(cards[0]);
        }
        else
        {
            Debug.Log("Deck is empty, the effect should fizzle");
        }

    }
    //*****************************************************************************




    //*****************************************************************************
    //These methods move cards from the Deck to their respective destination
    public void ToHand(Card card)
    {

        if (cards.Contains(card))
        {
            //Moves a specific card from the deck to the hand
            hand.AddCardToHand(card);
            //Removes the first instance of the card from the deck
            cards.Remove(card);
            ShuffleDeck();
        }
        else
        {
            Debug.Log("The card does not exist in the deck, effect fizzles");
        }


    }
    public void ToDiscardPile(Card card)
    {
        if (cards.Contains(card))
        {
            //Moves a specific card from the deck to the discard pile
            discardPile.AddToDiscard(card);
            //Removes the first instance of the card from the deck
            cards.Remove(card);
            ShuffleDeck();
        }
        else
        {
            Debug.Log("The card does not exist in the deck, effect fizzles");
        }

    }
    public void ToShield(Card card)
    {//Move a card from the top of the deck to the shield
        if (cards.Contains(card))
        {
            //Adds the top card of the deck to the Shield
            shield.AddToShield(card);
            //Removes the top card of the deck
            cards.Remove(card);
            ShuffleDeck();
        }
        else
        {
            Debug.Log("The card does not exist in the deck, effect fizzles");
        }


    }
    //*****************************************************************************


    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            foreach(Card card in cards) 
            {
                Debug.Log(card.card_name);
            }

            Debug.Log("Test");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ShuffleDeck();
            Debug.Log("Shuffled Deck!");
        }
    }

}
