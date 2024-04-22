using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDeck : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    private DiscardPile discardPile;
    private Shield shield;
    void Start()
    {
        discardPile = this.GetComponent<DiscardPile>();
        shield = this.GetComponent<Shield>();
    }
    public List<Card> GetCards()
    {
        return cards;
    }
    public void ShuffleExtraDeck()
    {
        cards.Shuffle();
    }
    public void PlayCard(Card card)
    {
        //Move card from extra deck to the field
    }

    public void AddToExtraDeck(Card card)
    {
        cards.Add(card);
    }

    //*****************************************************************************
    //These methods move cards from the Shield to their respective destination
    // Start is called before the first frame update

    public void ToDiscard(Card card)
    {
        if (cards.Contains(card))
        {

        }
        else
        {
            Debug.Log("This card does not exist in your Extra Deck, the effect fizzles");
        }

        discardPile.AddToDiscard(card);
        cards.Remove(card);
    }
    public void ToShield(Card card)
    {
        if (cards.Contains(card))
        {

        }
        else
        {
            Debug.Log("This card does not exist in your Extra Deck, the effect fizzles");
        }
        shield.AddToShield(card);
        cards.Remove(card);
    }
    //*****************************************************************************
}
