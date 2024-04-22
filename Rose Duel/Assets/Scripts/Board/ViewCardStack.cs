using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ViewCardStack : MonoBehaviour
{
    /*
     * This script will be used when the player clicks their own Extra Deck, Discard Pile or opponent's Discard Pile.
     * 
     * It will cause a UI window to come up with an array of cards (8 cards wide, by however many long).
     * 
     * The player will be able to click these cards and be able to read the card more clearly using the UI Card viewer on the left.
     * 
     * It will have an X button on the top left to close the window.
     * 
     * At the top of the window, there should be a textbox to show which card stack the player is viewing.
     */

    [Header("Prefabs")]
    [SerializeField] GameObject actionSkill;
    [SerializeField] GameObject deckLeader;
    [SerializeField] GameObject monster;
    [SerializeField] GameObject CardContainer;

    [Header("References")]
    [SerializeField] List<Card> cardStack = new List<Card>();
    [SerializeField] RectTransform cardViewerUI;
    [SerializeField] GameObject content;
    [SerializeField] GameObject exitButton;


    //If the player is already viewing a Card Stack (Deck, Extra Deck, Discard Pile, etc)
    //Then they cannot view another Card Stack at the same time.
    //They can view a new Card Stack after closing the view window.
    bool viewing = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClearList()
    {
        cardStack.Clear();
        for (int i = cardViewerUI.childCount; i > 0; i--)
        {
            Destroy(cardViewerUI.GetChild(i - 1).gameObject);
            Debug.Log("Destroyed a container");
        }
        viewing = false;
    }
    public void ViewCards(List<Card> cardPile)
    {
        if (!viewing)
        {
            viewing = true;

            content.SetActive(true);
            exitButton.SetActive(true);
            cardStack.AddRange(cardPile);

            cardStack.Sort((card1, card2) => card1.card_name.CompareTo(card2.card_name));
            int count = 0;
            int row = 0;

            if (cardStack.Count > 0)
            {
                while (count < cardStack.Count)
                {
                    var cardContainer = Instantiate(CardContainer, cardViewerUI);
                    for (int i = 0; i < 5; i++)
                    {//Fill the container with cards
                        if (count < cardStack.Count)
                        {
                            if (cardStack[count] is Monster_Card)
                            {
                                var monsterCard = Instantiate(monster, cardViewerUI.GetChild(row));
                                monsterCard.transform.SetParent(cardViewerUI.GetChild(row), false);
                                monsterCard.GetComponent<UICardDisplay>().card = cardStack[count];
                                monsterCard.GetComponent<UICardDisplay>().SetStats();
                            }
                            else if (cardStack[count] is Action_Card)
                            {
                                var Action_Skill = Instantiate(actionSkill, cardViewerUI.GetChild(row));
                                Action_Skill.GetComponent<UICardDisplay>().card = cardStack[count];
                                Action_Skill.GetComponent<UICardDisplay>().SetStats();
                            }
                            else if (cardStack[count] is Skill_Card)
                            {
                                var Action_Skill = Instantiate(actionSkill, cardViewerUI.GetChild(row));
                                Action_Skill.GetComponent<UICardDisplay>().card = cardStack[count];
                                Action_Skill.GetComponent<UICardDisplay>().SetStats();
                            }
                            else if (cardStack[count] is Deck_Leader_Card)
                            {
                                var Deck_Leader = Instantiate(deckLeader, cardViewerUI.GetChild(row));
                                Deck_Leader.GetComponent<UICardDisplay>().card = cardStack[count];
                                Deck_Leader.GetComponent<UICardDisplay>().SetStats();
                            }
                            count++;
                        }
                    }
                    row++;
                }
            }
        }

    }
}
