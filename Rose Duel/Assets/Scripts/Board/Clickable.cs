using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Clickable : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Events")]
    [SerializeField] GameEvent displayCardInfo;

    [Header("References")]
    [SerializeField] ViewCardStack cardStack;
    void Awake()
    {
        cardStack = GameObject.Find("Card Stack View Manager").GetComponent<ViewCardStack>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Clicked down the card");
        //throw new System.NotImplementedException();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Clicked up the card");
        //throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Clicked the card" + this.name);


        //CHANGE THIS TO CHECK THE OBJECT TAG
        if (this.GetComponent<CardDisplay>())
        {//If the clickable object has Card Display Script, send the card to be displayed

            Debug.Log("Card Display");
            displayCardInfo.Raise(this, this.GetComponent<CardDisplay>().card);
        }
        else if (this.GetComponent<Deck>())
        {
            cardStack.ViewCards(this.GetComponent<Deck>().GetCards());
        }
        else if (this.GetComponent<ExtraDeck>())
        {
            cardStack.ViewCards(this.GetComponent<ExtraDeck>().GetCards());
        }
        else if (this.GetComponent<Shield>())
        {
            cardStack.ViewCards(this.GetComponent<Shield>().GetCards());
        }
        else if (this.GetComponent<DiscardPile>())
        {
            cardStack.ViewCards(this.GetComponent<DiscardPile>().GetCards());
        }
        else
        {
            displayCardInfo.Raise();
        }

        //throw new System.NotImplementedException();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }





}
