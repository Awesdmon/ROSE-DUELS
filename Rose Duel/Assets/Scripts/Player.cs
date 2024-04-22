using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
     * This script will hold all the information about the player's field
     */

    public GameObject[] cardPrefab;
    public GameObject[] UICardPrefab;

    public Card[] deck;
    public GameObject[] deckCards;
    public GameObject[] extraDeckCards;
    public GameObject[] fieldPositions;
    public GameObject[] fieldCards;
    public GameObject[] handCards;
    public GameObject[] shield;


    public GameObject discard;
    public GameObject[] discardCards;

    public int deckCount, extraDeckCount, handCount, discardCount, energyCount;


    // Start is called before the first frame update
    void Start()
    {
        //Temporary


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
